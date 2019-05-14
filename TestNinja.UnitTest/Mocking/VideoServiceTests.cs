using Moq;
using NUnit.Framework;
using TestNinJa.Mocking;

namespace TestNinja.UnitTest.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var service = new VideoService(fileReader.Object);
            var result = service.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
