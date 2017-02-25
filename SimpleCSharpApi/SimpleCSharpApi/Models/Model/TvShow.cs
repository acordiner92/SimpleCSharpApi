using SimpleCSharpApi.Models.Request;

namespace SimpleCSharpApi.Models.Model
{
    /// <summary>
    /// Tv Show Class and logic
    /// </summary>
    public class TvShow
    {
        public TvShow(TvShowRequest r)
        {
            Drm = r.Drm;
            EpisodeCount = r.EpisodeCount;
            Image = r.ImageRequest != null ? r.ImageRequest.ShowImage : string.Empty;
            Slug = r.Slug;
            Title = r.Title;
        }

        public bool Drm { get; set; }

        public int EpisodeCount { get; set; }

        public string Image { get; set; }

        public string Slug { get; set; }

        public string Title { get; set; }

        public bool AtLeastOneEp()
        {
            return EpisodeCount > 0;
        }
    }
}