// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""6f9e8745-434c-4842-ace9-b0e8dc670f85"",
            ""actions"": [
                {
                    ""name"": ""GunLeft"",
                    ""type"": ""Value"",
                    ""id"": ""19790e88-7aaa-48ce-8537-4b12f2643cd8"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GunRight"",
                    ""type"": ""Value"",
                    ""id"": ""e7b0967b-0806-4306-beed-c7b36ce50f29"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""31895ac7-a43f-4edd-bca0-cad6aee2c4c2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""c207eca6-4a57-40db-89fa-30266b3d6f73"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""42b92348-35dd-45af-83db-fdf138c0aa34"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootRight"",
                    ""type"": ""Button"",
                    ""id"": ""b01e9a4c-5733-4680-bc53-fb870020dc23"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLeft"",
                    ""type"": ""Button"",
                    ""id"": ""8efbaf86-6331-4c7f-a84c-28de46641381"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowWeaponLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0b723934-69b6-43b7-8938-e69d43ffedc4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowWeaponRight"",
                    ""type"": ""Button"",
                    ""id"": ""cce77124-21a1-4a99-a210-3b71763c65f7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dd88415c-dd2e-4ea9-9751-a04052097ae6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GunLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fba8dc2-c2e4-4658-94ec-126befe4752b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GunRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac3d1142-0e56-454d-8309-4d61874fe3da"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c8f2603-7414-4e77-a3f5-9d05dbf21619"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ac0be38-2a31-4fd0-8c26-1751a467937c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eaaf082-ceba-4d5e-b810-1f649219474a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b99ca11-eb06-4374-bd79-16cb9f29dc55"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c6c05ab-7b89-4370-8731-29195491dde2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowWeaponLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24f0040d-9bbe-4a61-a414-954ca289b2c4"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowWeaponRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_GunLeft = m_Gameplay.FindAction("GunLeft", throwIfNotFound: true);
        m_Gameplay_GunRight = m_Gameplay.FindAction("GunRight", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_MoveRight = m_Gameplay.FindAction("MoveRight", throwIfNotFound: true);
        m_Gameplay_MoveLeft = m_Gameplay.FindAction("MoveLeft", throwIfNotFound: true);
        m_Gameplay_ShootRight = m_Gameplay.FindAction("ShootRight", throwIfNotFound: true);
        m_Gameplay_ShootLeft = m_Gameplay.FindAction("ShootLeft", throwIfNotFound: true);
        m_Gameplay_ThrowWeaponLeft = m_Gameplay.FindAction("ThrowWeaponLeft", throwIfNotFound: true);
        m_Gameplay_ThrowWeaponRight = m_Gameplay.FindAction("ThrowWeaponRight", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_GunLeft;
    private readonly InputAction m_Gameplay_GunRight;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_MoveRight;
    private readonly InputAction m_Gameplay_MoveLeft;
    private readonly InputAction m_Gameplay_ShootRight;
    private readonly InputAction m_Gameplay_ShootLeft;
    private readonly InputAction m_Gameplay_ThrowWeaponLeft;
    private readonly InputAction m_Gameplay_ThrowWeaponRight;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @GunLeft => m_Wrapper.m_Gameplay_GunLeft;
        public InputAction @GunRight => m_Wrapper.m_Gameplay_GunRight;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @MoveRight => m_Wrapper.m_Gameplay_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_Gameplay_MoveLeft;
        public InputAction @ShootRight => m_Wrapper.m_Gameplay_ShootRight;
        public InputAction @ShootLeft => m_Wrapper.m_Gameplay_ShootLeft;
        public InputAction @ThrowWeaponLeft => m_Wrapper.m_Gameplay_ThrowWeaponLeft;
        public InputAction @ThrowWeaponRight => m_Wrapper.m_Gameplay_ThrowWeaponRight;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @GunLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunLeft;
                @GunLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunLeft;
                @GunLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunLeft;
                @GunRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunRight;
                @GunRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunRight;
                @GunRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGunRight;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @MoveRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                @ShootRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootRight;
                @ShootRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootRight;
                @ShootRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootRight;
                @ShootLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootLeft;
                @ShootLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootLeft;
                @ShootLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootLeft;
                @ThrowWeaponLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponLeft;
                @ThrowWeaponLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponLeft;
                @ThrowWeaponLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponLeft;
                @ThrowWeaponRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponRight;
                @ThrowWeaponRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponRight;
                @ThrowWeaponRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnThrowWeaponRight;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GunLeft.started += instance.OnGunLeft;
                @GunLeft.performed += instance.OnGunLeft;
                @GunLeft.canceled += instance.OnGunLeft;
                @GunRight.started += instance.OnGunRight;
                @GunRight.performed += instance.OnGunRight;
                @GunRight.canceled += instance.OnGunRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @ShootRight.started += instance.OnShootRight;
                @ShootRight.performed += instance.OnShootRight;
                @ShootRight.canceled += instance.OnShootRight;
                @ShootLeft.started += instance.OnShootLeft;
                @ShootLeft.performed += instance.OnShootLeft;
                @ShootLeft.canceled += instance.OnShootLeft;
                @ThrowWeaponLeft.started += instance.OnThrowWeaponLeft;
                @ThrowWeaponLeft.performed += instance.OnThrowWeaponLeft;
                @ThrowWeaponLeft.canceled += instance.OnThrowWeaponLeft;
                @ThrowWeaponRight.started += instance.OnThrowWeaponRight;
                @ThrowWeaponRight.performed += instance.OnThrowWeaponRight;
                @ThrowWeaponRight.canceled += instance.OnThrowWeaponRight;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnGunLeft(InputAction.CallbackContext context);
        void OnGunRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnShootRight(InputAction.CallbackContext context);
        void OnShootLeft(InputAction.CallbackContext context);
        void OnThrowWeaponLeft(InputAction.CallbackContext context);
        void OnThrowWeaponRight(InputAction.CallbackContext context);
    }
}
