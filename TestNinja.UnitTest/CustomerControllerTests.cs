using NUnit.Framework;
using TestNinJa.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            //Not Found
            Assert.That(result, Is.TypeOf<NotFound>());

            //Not Found or one of its derivatives

            Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}
