using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebanx.net.Parameters.Requests.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestBase
    {
        /// <summary>
        /// If valid from datanotations return true
        /// </summary>
        public bool IsModelValid
        {
            get
            {
                return this.IsModelValid();
            }
        }
    }

    public static class Validation
    {
        public static bool IsModelValid(this object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);

            var msgReturn = "";

            foreach (var item in resultadoValidacao)
            {
                msgReturn += "-" + item.ErrorMessage + "\n";
            }

            if (string.IsNullOrEmpty(msgReturn))
                return true;

            throw new ArgumentException(msgReturn);
        }
    }
}
