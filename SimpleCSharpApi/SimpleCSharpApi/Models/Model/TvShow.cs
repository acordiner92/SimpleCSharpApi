using Newtonsoft.Json;
using SimpleCSharpApi.Models.Request;

namespace SimpleCSharpApi.Models.Model
{
    public class TvShow
    {
        public TvShow(TvShowRequest r)
        {
            Drm = r.Drm;
            EpisodeCount = r.EpisodeCount;
            Image = r.ImageRequest.ShowImage;
            Slug = r.Slug;
            Title = r.Title;
        }

        [JsonProperty("drm")]
        public bool Drm { get; set; }

        [JsonProperty("episodeCount")]
        public int EpisodeCount { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public bool AtLeastOneEp()
        {
            return EpisodeCount > 0;
        }
    }
}