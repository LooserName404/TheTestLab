using UnityEngine;
using UnityEngine.InputSystem;

namespace Rudder.Input
{
    public class RudderInputHandler
    {
        private readonly RudderInputSystem _rudderInput;

        public RudderInputHandler(RudderInputSystem rudderInput)
        {
            _rudderInput = rudderInput;
        }

        public Vector2 GetPosition()
        {
            return Mouse.current.position.ReadValue();
        }

        public bool IsMousePressed => Mouse.current.leftButton.isPressed;

        public bool IsPositionValid(Vector3 position, CircleCollider2D collider)
        {
            return collider.OverlapPoint(position);
        }
    }
}