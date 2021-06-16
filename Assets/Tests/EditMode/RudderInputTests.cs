using NUnit.Framework;
using Rudder.Input;
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
            RudderInputHandler inputHandler = A.RudderInputHandler;
            var mouse = InputSystem.AddDevice<Mouse>();
            var expected = new Vector2(100, 100);

            // ACT
            Press(mouse.leftButton);
            Move(mouse.position, expected);
            var actual = inputHandler.GetPosition();

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_ReturnTrue_When_MouseIsPressed()
        {
            // ARRANGE
            RudderInputHandler inputHandler = A.RudderInputHandler;
            var mouse = InputSystem.AddDevice<Mouse>();
            var position = new Vector2(100, 100);
            var expected = true;
            
            // ACT
            Press(mouse.leftButton);
            var actual = inputHandler.IsMousePressed;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_ReturnTrue_When_MouseIsPressedInRudderArea()
        {
            // ARRANGE
            var position = new Vector3(10, 15, 20);
            var collider = new GameObject().AddComponent<CircleCollider2D>();
            collider.radius = 30;

            RudderInputHandler inputHandler = A.RudderInputHandler;
            var mouse = InputSystem.AddDevice<Mouse>();
            
            var expected = true;

            // ACT
            Move(mouse.position, position);
            Press(mouse.leftButton);
            var actual = inputHandler.IsPositionValid(inputHandler.GetPosition(), collider);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}