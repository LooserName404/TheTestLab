using System;
using UnityEngine;

namespace Rudder
{
    public class SimpleMB : MonoBehaviour
    {

        private RudderInputSystem _rudderInput;
        private InputHandler _ih;
        private void Start()
        {
            _rudderInput = new RudderInputSystem();
            _rudderInput.Enable();
            _ih = new InputHandler(_rudderInput);
        }

        void Update()
        {
            _ih.GetPosition();
        }
    }
}
