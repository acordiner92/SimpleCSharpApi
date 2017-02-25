using System.Net;
using System.Web.Http;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;
using SimpleCSharpApi.Services;

namespace SimpleCSharpApi.Controllers
{
    [Route("")]
    public class TvShowController : ApiController
    {
        private readonly ITvShowService tvShowService;

        public TvShowController(ITvShowService tvShowService)
        {
            this.tvShowService = tvShowService;
        }

        public TvShowController()
        {
            tvShowService = new TvShowService();
        }

        [HttpPost]
        public IHttpActionResult Post(ApiRequest<TvShowRequest> apiRequest)
        {
            if (!ModelState.IsValid)
            {
                return Content(HttpStatusCode.BadRequest, new ErrorResponse("Could not decode request: JSON parsing failed"));
            }
            var response = tvShowService.GetFilteredTvShows(apiRequest.Payload);
            return Ok(new ApiResponse<TvShowResponse>(response));
        }
    }
}
