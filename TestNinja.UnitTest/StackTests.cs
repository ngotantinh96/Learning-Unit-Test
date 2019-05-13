using NUnit.Framework;
using TestNinJa.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }

        [Test]
        public void Pop_WhenAddNull_ThrowNullException()
        {
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_WhenAdded_ListCountGreatedThanZero()
        {
            stack.Push("Tinh");
            Assert.That(stack.Count, Is.EqualTo(1));
        }
    }
}
