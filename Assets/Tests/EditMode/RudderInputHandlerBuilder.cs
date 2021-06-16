using Rudder.Input;
using UnityEngine;

namespace Tests.EditMode
{
    public class RudderInputHandlerBuilder
    {
        private CircleCollider2D _collider;

        public RudderInputHandler Build()
        {
            var inputSystem = new RudderInputSystem();
            inputSystem.Enable();
            return new RudderInputHandler(inputSystem);
        }

        public static implicit operator RudderInputHandler(RudderInputHandlerBuilder builder)
        {
            return builder.Build();
        }
    }
}