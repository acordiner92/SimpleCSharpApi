using System.Collections.Generic;
using System.Web.Http;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;
using SimpleCSharpApi.Services;

namespace SimpleCSharpApi.Controllers
{
    [Route("/")]
    public class TvShowController : ApiController
    {
        private readonly ITvShowService tvShowService;

        public TvShowController()
        {
            tvShowService = new TvShowService();
        }

        [HttpPost]
        public IHttpActionResult Post(PayloadRequest<TvShowRequest> payloadRequest)
        {
            var response = tvShowService.GetFilterTvShows(payloadRequest.Payload);
            return Ok(new ApiResponse<List<TvShowResponse>>(response));
        }
    }
}
