using System.Collections.Generic;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;

namespace SimpleCSharpApi.Services
{
    /// <summary>
    ///     Interface for TvShowService
    /// </summary>
    public interface ITvShowService
    {
        /// <summary>
        ///     Filters the tv shows based on if there is more than one episode
        ///     and whether the drm is enabled
        /// </summary>
        /// <param name="tvShowRequests"></param>
        /// <returns></returns>
        List<TvShowResponse> GetFilteredTvShows(List<TvShowRequest> tvShowRequests);
    }
}