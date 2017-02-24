using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SimpleCSharpApi.Models.Request;
using SimpleCSharpApi.Services;

namespace SimpleCSharpApi.Tests.Services
{
    public class TvShowsServiceTests
    {
        /// <summary>
        ///     This test checks to see if a TvShowRequesst which has the correct
        ///     critea is passed in, it will return a response object
        /// </summary>
        [Test]
        public void Check_It_Correctly_Returns_Drm_Enabled_And_More_Than_One_Eposide()
        {
            // Setup
            var validRequest = new List<TvShowRequest>
            {
                new TvShowRequest
                {
                    Drm = true,
                    EpisodeCount = 3,
                    Title = "cool show",
                    ImageRequest = new ImageRequest()
                }
            };

            var tvShowService = new TvShowService();

            // Action
            var tvShowResp = tvShowService.GetFilterTvShows(validRequest);

            // Assert
            Assert.That(tvShowResp.Count, Is.EqualTo(1));
            Assert.That(tvShowResp.First().Title, Is.EqualTo(validRequest[0].Title));
        }

        /// <summary>
        ///     This test checks to see if a TvShowResponse has the correct
        ///     information taken from a valid TvShowRequest
        /// </summary>
        [Test]
        public void Check_Reponse_Contains_Correct_Info_From_Request()
        {
            // Setup
            var validRequest = new List<TvShowRequest>
            {
                new TvShowRequest
                {
                    Drm = true,
                    EpisodeCount = 3,
                    Title = "cool show",
                    Slug = "sluginfo",
                    ImageRequest = new ImageRequest
                    {
                        ShowImage = "imageurl"
                    }
                }
            };

            var tvShowService = new TvShowService();

            // Action
            var tvShowResp = tvShowService.GetFilterTvShows(validRequest);

            // Assert
            Assert.That(tvShowResp.Count, Is.EqualTo(1));
            Assert.That(tvShowResp.First().Title, Is.EqualTo(validRequest[0].Title));
            Assert.That(tvShowResp.First().Image, Is.EqualTo(validRequest[0].ImageRequest.ShowImage));
            Assert.That(tvShowResp.First().Slug, Is.EqualTo(validRequest[0].Slug));
        }

        /// <summary>
        ///     This test checks to see if a TvShowRequesst which has the incorrect
        ///     criteas is passed in, it will return an empty response list
        /// </summary>
        [Test]
        public void Check_It_Returns_Empty_List_If_Does_Not_Match_Filter_Critea()
        {
            // Setup

            var noDrmRequest = new TvShowRequest
            {
                Drm = false,
                EpisodeCount = 3,
                Title = "show 1",
                ImageRequest = new ImageRequest()
            };

            var zeroEpisodeCountRequest =
                new TvShowRequest
                {
                    Drm = true,
                    EpisodeCount = 0,
                    Title = "show 2",
                    ImageRequest = new ImageRequest()
                };

            var tvShowService = new TvShowService();

            // Action
            var tvShowResp = tvShowService.GetFilterTvShows(new List<TvShowRequest> {noDrmRequest, zeroEpisodeCountRequest});

            // Assert
            Assert.That(tvShowResp.Count, Is.EqualTo(0));
        }
    }
}