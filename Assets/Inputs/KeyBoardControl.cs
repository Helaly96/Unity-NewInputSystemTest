// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/KeyBoardControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KeyBoardControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeyBoardControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KeyBoardControl"",
    ""maps"": [
        {
            ""name"": ""Test"",
            ""id"": ""32971c8f-9feb-4265-ad16-6cb59665a941"",
            ""actions"": [
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""8b82dc56-ef73-45cf-a1c0-bac556bba5dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""b22889fb-9437-4795-addd-f70501ebd5dc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""25b27898-18f4-418b-b522-3564ecbd1480"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ce0e2b93-478c-4c07-93fe-0e8d05f8a647"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowUp"",
                    ""type"": ""Button"",
                    ""id"": ""ae20724e-5f07-4160-a67c-a51cbaf7ab2f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1c35549-a036-44c0-82d7-7cebce263342"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a7cd53d-2426-46a0-85d3-d5e233df3e0d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d5bcd42-1eb2-456d-b67c-cda51ca2a75f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4983bcf5-8152-494e-9c75-c9b277f8ff91"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5281f13c-689a-4b76-a6c8-b14bc5dbe507"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_D = m_Test.FindAction("D", throwIfNotFound: true);
        m_Test_A = m_Test.FindAction("A", throwIfNotFound: true);
        m_Test_Space = m_Test.FindAction("Space", throwIfNotFound: true);
        m_Test_Fire = m_Test.FindAction("Fire", throwIfNotFound: true);
        m_Test_ThrowUp = m_Test.FindAction("ThrowUp", throwIfNotFound: true);
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

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_D;
    private readonly InputAction m_Test_A;
    private readonly InputAction m_Test_Space;
    private readonly InputAction m_Test_Fire;
    private readonly InputAction m_Test_ThrowUp;
    public struct TestActions
    {
        private @KeyBoardControl m_Wrapper;
        public TestActions(@KeyBoardControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @D => m_Wrapper.m_Test_D;
        public InputAction @A => m_Wrapper.m_Test_A;
        public InputAction @Space => m_Wrapper.m_Test_Space;
        public InputAction @Fire => m_Wrapper.m_Test_Fire;
        public InputAction @ThrowUp => m_Wrapper.m_Test_ThrowUp;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @D.started -= m_Wrapper.m_TestActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnD;
                @A.started -= m_Wrapper.m_TestActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnA;
                @Space.started -= m_Wrapper.m_TestActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnSpace;
                @Fire.started -= m_Wrapper.m_TestActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnFire;
                @ThrowUp.started -= m_Wrapper.m_TestActionsCallbackInterface.OnThrowUp;
                @ThrowUp.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnThrowUp;
                @ThrowUp.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnThrowUp;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @ThrowUp.started += instance.OnThrowUp;
                @ThrowUp.performed += instance.OnThrowUp;
                @ThrowUp.canceled += instance.OnThrowUp;
            }
        }
    }
    public TestActions @Test => new TestActions(this);
    public interface ITestActions
    {
        void OnD(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnThrowUp(InputAction.CallbackContext context);
    }
}
