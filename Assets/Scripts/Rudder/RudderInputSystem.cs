// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Rudder/RudderInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Rudder
{
    public class RudderInputSystem : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public RudderInputSystem()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""RudderInputSystem"",
    ""maps"": [
        {
            ""name"": ""Rudder"",
            ""id"": ""8df6ccdc-ce20-48d0-bb18-ad02e66db1a7"",
            ""actions"": [
                {
                    ""name"": ""HoldRudder"",
                    ""type"": ""Button"",
                    ""id"": ""ade35e81-2a05-488b-91e2-0ba064de39a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc15e623-e977-4190-9e47-722f9c928da9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7f431194-d343-404a-82a1-ac45f1c930de"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoldRudder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e859bd9-87f0-41d7-b0bb-f4a077602d92"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rudder
            m_Rudder = asset.FindActionMap("Rudder", throwIfNotFound: true);
            m_Rudder_HoldRudder = m_Rudder.FindAction("HoldRudder", throwIfNotFound: true);
            m_Rudder_MousePosition = m_Rudder.FindAction("MousePosition", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Rudder
        private readonly InputActionMap m_Rudder;
        private IRudderActions m_RudderActionsCallbackInterface;
        private readonly InputAction m_Rudder_HoldRudder;
        private readonly InputAction m_Rudder_MousePosition;
        public struct RudderActions
        {
            private RudderInputSystem m_Wrapper;
            public RudderActions(RudderInputSystem wrapper) { m_Wrapper = wrapper; }
            public InputAction @HoldRudder => m_Wrapper.m_Rudder_HoldRudder;
            public InputAction @MousePosition => m_Wrapper.m_Rudder_MousePosition;
            public InputActionMap Get() { return m_Wrapper.m_Rudder; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RudderActions set) { return set.Get(); }
            public void SetCallbacks(IRudderActions instance)
            {
                if (m_Wrapper.m_RudderActionsCallbackInterface != null)
                {
                    @HoldRudder.started -= m_Wrapper.m_RudderActionsCallbackInterface.OnHoldRudder;
                    @HoldRudder.performed -= m_Wrapper.m_RudderActionsCallbackInterface.OnHoldRudder;
                    @HoldRudder.canceled -= m_Wrapper.m_RudderActionsCallbackInterface.OnHoldRudder;
                    @MousePosition.started -= m_Wrapper.m_RudderActionsCallbackInterface.OnMousePosition;
                    @MousePosition.performed -= m_Wrapper.m_RudderActionsCallbackInterface.OnMousePosition;
                    @MousePosition.canceled -= m_Wrapper.m_RudderActionsCallbackInterface.OnMousePosition;
                }
                m_Wrapper.m_RudderActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HoldRudder.started += instance.OnHoldRudder;
                    @HoldRudder.performed += instance.OnHoldRudder;
                    @HoldRudder.canceled += instance.OnHoldRudder;
                    @MousePosition.started += instance.OnMousePosition;
                    @MousePosition.performed += instance.OnMousePosition;
                    @MousePosition.canceled += instance.OnMousePosition;
                }
            }
        }
        public RudderActions @Rudder => new RudderActions(this);
        public interface IRudderActions
        {
            void OnHoldRudder(InputAction.CallbackContext context);
            void OnMousePosition(InputAction.CallbackContext context);
        }
    }
}
