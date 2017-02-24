using System;
using System.Web.Http;
using Newtonsoft.Json;
using SimpleCSharpApi.Models.Request;

namespace SimpleCSharpApi.Controllers
{
    [Route("api/tvshow")]
    public class TvShowController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(PayloadRequest<TvShowRequest> payload)
        {
            return Ok();
        }
    }
}
