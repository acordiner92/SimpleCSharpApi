using System.Collections.Generic;
using System.Web.Http;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;
using SimpleCSharpApi.Services;

namespace SimpleCSharpApi.Controllers
{
    [Route("api/tv-shows")]
    public class TvShowController : ApiController
    {
        private readonly ITvShowService tvShowService;

        public TvShowController()
        {
            tvShowService = new TvShowService();
        }

        [HttpPost]
        public IHttpActionResult Post(ApiRequest<TvShowRequest> apiRequest)
        {
            var response = tvShowService.GetFilterTvShows(apiRequest.Payload);
            return Ok(new ApiResponse<List<TvShowResponse>>(response));
        }
    }
}
