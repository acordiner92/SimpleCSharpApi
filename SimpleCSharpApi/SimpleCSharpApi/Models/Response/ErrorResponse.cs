using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Response
{
    /// <summary>
    ///     Error response object for all Api Errors
    /// </summary>
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