using System.Collections.Generic;
using System.Net;
using System.Web.Http.Results;
using Moq;
using NUnit.Framework;
using SimpleCSharpApi.Controllers;
using SimpleCSharpApi.Models.Model;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Models.Response;
using SimpleCSharpApi.Services;

namespace SimpleCSharpApi.Tests.Controllers
{
    public class TvShowControllerTests
    {
        /// <summary>
        ///     Checks to see if a valid ApiRequest of TvShowRequests is posted
        ///     then an Ok response is sent back
        /// </summary>
        [Test]
        public void Check_Modal_State_Is_Valid_Then_Response_Ok()
        {
            // Setup
            var mockTvShowService = new Mock<ITvShowService>();
            mockTvShowService.Setup(x => x.GetFilteredTvShows(It.IsAny<List<TvShowRequest>>())).Returns(
                new List<TvShowResponse>
                {
                    new TvShowResponse(new TvShow(new TvShowRequest
                    {
                        Drm = true,
                        EpisodeCount = 3,
                        ImageRequest = new ImageRequest(),
                        Slug = "dd",
                        Title = "ddd"
                    }))
                });


            // Action
            var controller = new TvShowController(mockTvShowService.Object);
            var actionResult = controller.Post(new ApiRequest<TvShowRequest>());

            // Assert
            var okRes = actionResult as OkNegotiatedContentResult<ApiResponse<TvShowResponse>>;
            Assert.IsNotNull(okRes);
        }

        /// <summary>
        ///     Checks to see if invalid json is posted then a badrequest response is
        ///     sent back with a error message
        /// </summary>
        [Test]
        public void Check_Bad_Request_With_Message_Is_Response_When_Invalid_Json_Is_Sent()
        {
            // Setup
            var controller = new TvShowController();


            // Action
            controller.ModelState.AddModelError("test", "test");
            var actionResult = controller.Post(new ApiRequest<TvShowRequest>());

            // Assert
            var badRequest = actionResult as NegotiatedContentResult<ErrorResponse>;
            Assert.IsNotNull(badRequest);
            Assert.That(badRequest.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            Assert.That(badRequest.Content.Error, Is.EqualTo("Could not decode request: JSON parsing failed"));
        }
    }
}