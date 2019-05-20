using Moq;
using NUnit.Framework;
using TestNinJa.Mocking;

namespace TestNinja.UnitTest.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();

            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));
        }
    }
}
