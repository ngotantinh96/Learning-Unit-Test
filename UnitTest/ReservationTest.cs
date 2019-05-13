using LearningUnitTest.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrannge
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCanceledBy(new User { IsAdmin = true });
            //Assert

            Assert.IsTrue(result);
        }
    }
}
