using System.Diagnostics.CodeAnalysis;
using Microsoft.QualityTools.Testing.Fakes;
using Moq;
using Newtonsoft.Json.Fakes;
using NUnit.Framework;
using Shouldly;
using TestNinja.Mocking;

namespace Demo.UnitTests
{
    /// <summary>
    /// Unit Tests for <see cref="VideoService"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class VideoServiceTest
    {
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
        }

        [Test]
        public void ReadVideoTitle_WhenCalledWithEmptyVideoFile_ShouldReturnParsingError()
        {
            // Arrange
            _fileReader.Setup(x => x.Read("video.txt")).Returns(string.Empty);
            var videoService = new VideoService(_fileReader.Object);

            // Act
            var title = videoService.ReadVideoTitle();

            // Assert
            title.ShouldBe("Error parsing the video.");
        }

        [Test]
        public void ReadVideoTitle_WhenCalledWithVideoFile_ShouldReturnTitle()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                var videoService = new VideoService(_fileReader.Object);
                ShimJsonConvert.DeserializeObjectOf1String(_ => new Video
                {
                    Title = "video"
                });

                // Act
                var title = videoService.ReadVideoTitle();

                // Assert
                title.ShouldBe("video");
            }
        }
    }
}
