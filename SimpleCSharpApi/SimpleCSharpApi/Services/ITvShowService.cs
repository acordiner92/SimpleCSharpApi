using System.Collections.Generic;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;

namespace SimpleCSharpApi.Services
{
    interface ITvShowService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tvShowRequests"></param>
        /// <returns></returns>
        List<TvShowResponse> GetFilterTvShows(List<TvShowRequest> tvShowRequests);
    }
}
