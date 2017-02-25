using System.Collections.Generic;
using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Response
{
    public class ApiResponse<T>
    {
        public ApiResponse(List<T> response)
        {
            Response = response;
        }

        [JsonProperty("response")]
        public List<T> Response { get; set; }
    }
}