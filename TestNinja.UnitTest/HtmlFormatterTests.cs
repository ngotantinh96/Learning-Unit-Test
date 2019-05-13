using NUnit.Framework;
using TestNinJa.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);

        }
    }
}
