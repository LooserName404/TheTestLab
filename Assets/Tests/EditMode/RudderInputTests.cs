using NUnit.Framework;
using Rudder;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Tests.EditMode
{
    public class RudderInputTests : InputTestFixture
    {
        [Test]
        public void Should_ReturnMousePosition_When_CallGetPosition()
        {
            // ARRANGE
            var inputSystem = new RudderInputSystem();
            inputSystem.Enable();
            var mouse = InputSystem.AddDevice<Mouse>();
            
            var inputHandler = new InputHandler(inputSystem);
            var expected = new Vector2(100, 100);
            
            // ACT
            Press(mouse.leftButton);
            Move(mouse.position, expected);
            var actual = inputHandler.GetPosition();
            
            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_ReturnNegative_When_MouseIsNotPressed()
        {
            // ARRANGE
            var inputSystem = new RudderInputSystem();
            inputSystem.Enable();
            var mouse = InputSystem.AddDevice<Mouse>();

            var inputHandler = new InputHandler(inputSystem);
            var expected1 = new Vector2(100, 100);
            var expected2 = new Vector2(-1, -1);

            // ACT
            Press(mouse.leftButton);
            Move(mouse.position, expected1);
            var actual1 = inputHandler.GetPosition();
            
            Release(mouse.leftButton);
            var actual2 = inputHandler.GetPosition();

            // ASSERT
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}