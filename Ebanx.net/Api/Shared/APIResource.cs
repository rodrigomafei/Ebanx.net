using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public interface IApiResources : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        string BaseURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<T> GetAsync<T>(object data);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<T> PostAsync<T>(object data);
    }

    /// <summary>
    /// 
    /// </summary>
    public class APIResource : IApiResources
    {
        private readonly IHttpClientWrapper client;
        private readonly JsonSerializerSettings JsonSettings;

        /// <summary>
        /// 
        /// </summary>
        private string _baseURI;
        public string BaseURI
        {
            get { return _baseURI; }
            set { _baseURI = Constants.APIUrlStag + "" + value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customClient"></param>
        /// <param name="customJsonSerializerSettings"></param>
        public APIResource(IHttpClientWrapper customClient, JsonSerializerSettings customJsonSerializerSettings = null)
        {
            client = customClient;
            JsonSettings = customJsonSerializerSettings ?? new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        }

        /// <summary>
        /// 
        /// </summary>
        public APIResource() : this(new StandardHttpClient(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            client.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(object data)
        {
            //var completeUrl = GetCompleteUrl();
            var response = await SendRequestAsync(HttpMethod.Get, BaseURI, data).ConfigureAwait(false);
            return await ProcessResponse<T>(response).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PostAsync<T>(object data)
        {
            var response = await SendRequestAsync(HttpMethod.Post, BaseURI, data).ConfigureAwait(false);
            return await ProcessResponse<T>(response).ConfigureAwait(false);
        }

        private async Task<T> ProcessResponse<T>(HttpResponseMessage response)
        {
            var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await Task.FromResult(JsonConvert.DeserializeObject<T>(data, JsonSettings)).ConfigureAwait(false);
            }

            throw new ArgumentException(response.RequestMessage.ToString());
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpMethod method, string url, object data = null, string customToken = null)
        {
            using (var requestMessage = new HttpRequestMessage(method, url))
            {
                await SetContent(data, requestMessage);
                return await client.SendAsync(requestMessage).ConfigureAwait(false);
            }
        }

        private async Task SetContent(object data, HttpRequestMessage requestMessage)
        {
            if (data != null)
            {
                var content = await Task.FromResult(JsonConvert.SerializeObject(data, JsonSettings)).ConfigureAwait(false);
                requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
            }
        }
    }
}
