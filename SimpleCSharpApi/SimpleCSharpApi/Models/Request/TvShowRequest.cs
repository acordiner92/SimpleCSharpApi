using Newtonsoft.Json;

namespace SimpleCSharpApi.Models.Request
{
    public class TvShowRequest
    {
        [JsonProperty("drm")]
        public bool Drm { get; set; }

        [JsonProperty("episodeCount")]
        public int EpisodeCount { get; set; }

        [JsonProperty("image")]
        public ImageRequest ImageRequest { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}