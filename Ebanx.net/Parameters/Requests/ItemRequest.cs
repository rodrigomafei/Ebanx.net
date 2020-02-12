using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    public class ItemRequest
    {
        /// <summary>
        /// SKU of the item
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Price of the unity of the item
        /// </summary>
        [JsonProperty("unit_price")]
        public float UnitPrice { get; set; }

        /// <summary>
        /// Quantity of each item
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Type of the item
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
