using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Response
{
    public class ApiResponse<T>
    {
        public ApiResponse(T response)
        {
            Response = response;
        }

        [JsonProperty("response")]
        public T Response { get; set; }
    }
}