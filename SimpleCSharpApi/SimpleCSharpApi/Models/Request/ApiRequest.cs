using System.Collections.Generic;
using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Request
{
    /// <summary>
    ///    Base Request Object for Api Requests
    /// </summary>
    public class ApiRequest<T>
    {
        [JsonProperty("payload")]
        public List<T> Payload { get; set; } 
    }
}