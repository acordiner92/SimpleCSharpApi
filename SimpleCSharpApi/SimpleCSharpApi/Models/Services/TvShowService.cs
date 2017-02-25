using System.Collections.Generic;
using System.Linq;
using SimpleCSharpApi.Models.Model;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;

namespace SimpleCSharpApi.Services
{
    public class TvShowService : ITvShowService
    {
        public List<TvShowResponse> GetFilteredTvShows(List<TvShowRequest> tvShowRequests)
        {
            if (tvShowRequests == null) return new List<TvShowResponse>();
            var tvShows = tvShowRequests.Select(x => new TvShow(x)).ToList();
            return tvShows.Where(x => x.AtLeastOneEp() && x.Drm).Select(x => new TvShowResponse(x)).ToList();
        }
    }
}