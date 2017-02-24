using System.Collections.Generic;
using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Request
{
    public class PayloadRequest<T>
    {
        [JsonProperty("payload")]
        public List<T> Payload { get; set; } 
    }
}