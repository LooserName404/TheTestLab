using NUnit.Framework;
using Rudder.Physics;
using UnityEngine;

namespace Tests.EditMode
{
    public class AngleCalculatorTests
    {
        [Test]
        public void Should_ReturnCorrectAngle_When_CalculateIsCalled()
        {
            // ARRANGE
            var angleCalculator = new AngleCalculator();
            
            var fakeMousePosition = new Vector3(10,15, 20);
            var fakeRudderPosition = new Vector3(3, 6, 9);
            
            var vectorAngle = (fakeMousePosition - fakeRudderPosition).normalized;
            
            var expected = Quaternion.LookRotation(Vector3.forward, vectorAngle);

            // ACT
            var actual = angleCalculator.Calculate(vectorAngle);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}