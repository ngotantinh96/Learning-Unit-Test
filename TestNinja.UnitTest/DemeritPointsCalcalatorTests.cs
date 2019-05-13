using NUnit.Framework;
using System;
using TestNinJa.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class DemeritPointsCalcalatorTests
    {
        private DemeritPointsCalcalator demeritPointsCalcalator;

        [SetUp]
        public void SetUp()
        {
            demeritPointsCalcalator = new DemeritPointsCalcalator();
        }

        [Test]
        public void CalculateDemeritPoints_InputSmallerThan0_ThrowException()
        {
            Assert.That(() => demeritPointsCalcalator.CalculateDemeritPoints(-5),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(60, 0)]
        [TestCase(70, 1)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int demeritPoints)
        {
            var result = demeritPointsCalcalator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(demeritPoints));
        }
    }
}
