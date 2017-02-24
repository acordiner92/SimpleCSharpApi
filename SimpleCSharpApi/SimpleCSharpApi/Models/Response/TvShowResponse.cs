using Newtonsoft.Json;
using SimpleCSharpApi.Models.Model;

namespace SimpleCSharpApi.Models.Response
{
    public class TvShowResponse
    {
        public TvShowResponse(TvShow s)
        {
            Image = s.Image;
            Slug = s.Slug;
            Title = s.Title;
        }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; } 
    }
}