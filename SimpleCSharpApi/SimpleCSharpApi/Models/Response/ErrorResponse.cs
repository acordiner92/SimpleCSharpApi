using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Response
{
    public class ErrorResponse
    {
        public ErrorResponse(string error)
        {
            Error = error;
        }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}