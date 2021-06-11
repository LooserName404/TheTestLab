using UnityEngine;
using UnityEngine.InputSystem;

namespace Rudder
{
    public class InputHandler
    {
        private RudderInputSystem _rudderInput;

        public InputHandler(RudderInputSystem rudderInput)
        {
            _rudderInput = rudderInput;
        }
        
        public Vector2 GetPosition()
        {
            if (Mouse.current.leftButton.isPressed)
            {
                return _rudderInput.Rudder.MousePosition.ReadValue<Vector2>();
            }

            return new Vector2(-1, -1);
        }
    }
}