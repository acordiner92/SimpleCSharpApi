using NUnit.Framework;
using SimpleCSharpApi.Models.Model;
using SimpleCSharpApi.Models.Request;

namespace SimpleCSharpApi.Tests.Models.Model
{
    public class TvShowTests
    {
        [Test]
        public void Check_AtLeastOneEp_Returns_True_If_Tv_Show_Has_More_Than_One_Episode()
        {
            // Setup
            var tvShow = new TvShow(new TvShowRequest
            {
                EpisodeCount = 4
            });

            // Action
            var resp = tvShow.AtLeastOneEp();

            // Assert
            Assert.That(resp, Is.EqualTo(true));
        }

        [Test]
        public void Check_If_Tv_Show_Has_Zero_Episodes_Then_AtLeastOneEp_Returns_False()
        {
            // Setup
            var tvShow = new TvShow(new TvShowRequest
            {
                EpisodeCount = 0
            });

            // Action
            var resp = tvShow.AtLeastOneEp();

            // Assert
            Assert.That(resp, Is.EqualTo(false));
        }

        [Test]
        public void Check_If_Tv_Request_Has_No_Image_Request_Info_Then_TvShow_Image_Should_Be_An_Empty_String()
        {
            // Setup
            var noImageTvRequest = new TvShowRequest
            {
                ImageRequest = null,
                EpisodeCount = 0
            };

            // Action
            var tvShow = new TvShow(noImageTvRequest);

            // Assert
            Assert.That(tvShow.Image, Is.EqualTo(string.Empty));
        }
    }
}