//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/01_Scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""60720723-9ff6-4b22-8198-24aaf5d53a2a"",
            ""actions"": [
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""43e85871-aa54-4b99-91b9-4e663883af86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cell_1"",
                    ""type"": ""Button"",
                    ""id"": ""183fba13-da00-483d-ad6d-566fdb8737f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cell_2"",
                    ""type"": ""Button"",
                    ""id"": ""05ac32f5-17d8-47f3-9ada-d9e3b119f176"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cell_3"",
                    ""type"": ""Button"",
                    ""id"": ""173e61e9-5064-4670-8845-21fc5bc6d3d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cell_4"",
                    ""type"": ""Button"",
                    ""id"": ""65dbddc0-e3f1-446f-baf9-2d5af05e9aba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5208793a-f5ee-4a36-852f-616216ec1c72"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cell_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aaf7e06-5cc7-44c0-8afc-6294b3527deb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cell_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4999b97a-4406-4df2-860d-8cdfc266563e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cell_4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c4bc78d-1ebe-4681-a2ca-16388bbf8e44"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b80d1fd-d60f-4f81-b072-aa6c6c0ee1c8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cell_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Hit = m_Player.FindAction("Hit", throwIfNotFound: true);
        m_Player_Cell_1 = m_Player.FindAction("Cell_1", throwIfNotFound: true);
        m_Player_Cell_2 = m_Player.FindAction("Cell_2", throwIfNotFound: true);
        m_Player_Cell_3 = m_Player.FindAction("Cell_3", throwIfNotFound: true);
        m_Player_Cell_4 = m_Player.FindAction("Cell_4", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Hit;
    private readonly InputAction m_Player_Cell_1;
    private readonly InputAction m_Player_Cell_2;
    private readonly InputAction m_Player_Cell_3;
    private readonly InputAction m_Player_Cell_4;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hit => m_Wrapper.m_Player_Hit;
        public InputAction @Cell_1 => m_Wrapper.m_Player_Cell_1;
        public InputAction @Cell_2 => m_Wrapper.m_Player_Cell_2;
        public InputAction @Cell_3 => m_Wrapper.m_Player_Cell_3;
        public InputAction @Cell_4 => m_Wrapper.m_Player_Cell_4;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Hit.started += instance.OnHit;
            @Hit.performed += instance.OnHit;
            @Hit.canceled += instance.OnHit;
            @Cell_1.started += instance.OnCell_1;
            @Cell_1.performed += instance.OnCell_1;
            @Cell_1.canceled += instance.OnCell_1;
            @Cell_2.started += instance.OnCell_2;
            @Cell_2.performed += instance.OnCell_2;
            @Cell_2.canceled += instance.OnCell_2;
            @Cell_3.started += instance.OnCell_3;
            @Cell_3.performed += instance.OnCell_3;
            @Cell_3.canceled += instance.OnCell_3;
            @Cell_4.started += instance.OnCell_4;
            @Cell_4.performed += instance.OnCell_4;
            @Cell_4.canceled += instance.OnCell_4;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Hit.started -= instance.OnHit;
            @Hit.performed -= instance.OnHit;
            @Hit.canceled -= instance.OnHit;
            @Cell_1.started -= instance.OnCell_1;
            @Cell_1.performed -= instance.OnCell_1;
            @Cell_1.canceled -= instance.OnCell_1;
            @Cell_2.started -= instance.OnCell_2;
            @Cell_2.performed -= instance.OnCell_2;
            @Cell_2.canceled -= instance.OnCell_2;
            @Cell_3.started -= instance.OnCell_3;
            @Cell_3.performed -= instance.OnCell_3;
            @Cell_3.canceled -= instance.OnCell_3;
            @Cell_4.started -= instance.OnCell_4;
            @Cell_4.performed -= instance.OnCell_4;
            @Cell_4.canceled -= instance.OnCell_4;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnHit(InputAction.CallbackContext context);
        void OnCell_1(InputAction.CallbackContext context);
        void OnCell_2(InputAction.CallbackContext context);
        void OnCell_3(InputAction.CallbackContext context);
        void OnCell_4(InputAction.CallbackContext context);
    }
}
