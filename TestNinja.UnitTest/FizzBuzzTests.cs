using NUnit.Framework;
using TestNinJa.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "Fizz Buzz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "11")]
        public void GetOutput_WhenCalled_ReturnExpectedString(int number, string expectedString)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
