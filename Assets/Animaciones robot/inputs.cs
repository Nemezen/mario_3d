//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Animaciones robot/inputs.inputactions
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

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inputs"",
    ""maps"": [
        {
            ""name"": ""charactercontrol"",
            ""id"": ""6d8dcb69-0d5f-4ee4-ae37-7c0aaced23bd"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""d3589e8b-015b-47c3-b10e-467351b5dc02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""f433515c-159c-42f0-8541-7e080670864f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""run"",
                    ""type"": ""Button"",
                    ""id"": ""cafb3f49-2210-4244-9fd9-403bde41e2e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c95b78e3-0a0e-4dc2-9a96-04bc6d91ff85"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd5aa8d0-95fc-430c-ae99-9c155c24bdb1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""165cf1e6-de33-4ec1-8e6c-76223eae3c3c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4432cec8-afd6-468f-b890-2257a65fdf9d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8a531ab1-53cc-4c1c-ab6c-d14d9f3c39cb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c55dcf7-b331-4272-8e42-520c26b0d477"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74a28dfb-0364-49d9-91a8-9f831a66372c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61d7d6ab-5b5b-4f89-bae1-01542555370f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // charactercontrol
        m_charactercontrol = asset.FindActionMap("charactercontrol", throwIfNotFound: true);
        m_charactercontrol_jump = m_charactercontrol.FindAction("jump", throwIfNotFound: true);
        m_charactercontrol_move = m_charactercontrol.FindAction("move", throwIfNotFound: true);
        m_charactercontrol_run = m_charactercontrol.FindAction("run", throwIfNotFound: true);
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

    // charactercontrol
    private readonly InputActionMap m_charactercontrol;
    private List<ICharactercontrolActions> m_CharactercontrolActionsCallbackInterfaces = new List<ICharactercontrolActions>();
    private readonly InputAction m_charactercontrol_jump;
    private readonly InputAction m_charactercontrol_move;
    private readonly InputAction m_charactercontrol_run;
    public struct CharactercontrolActions
    {
        private @Inputs m_Wrapper;
        public CharactercontrolActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_charactercontrol_jump;
        public InputAction @move => m_Wrapper.m_charactercontrol_move;
        public InputAction @run => m_Wrapper.m_charactercontrol_run;
        public InputActionMap Get() { return m_Wrapper.m_charactercontrol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharactercontrolActions set) { return set.Get(); }
        public void AddCallbacks(ICharactercontrolActions instance)
        {
            if (instance == null || m_Wrapper.m_CharactercontrolActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharactercontrolActionsCallbackInterfaces.Add(instance);
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @run.started += instance.OnRun;
            @run.performed += instance.OnRun;
            @run.canceled += instance.OnRun;
        }

        private void UnregisterCallbacks(ICharactercontrolActions instance)
        {
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @run.started -= instance.OnRun;
            @run.performed -= instance.OnRun;
            @run.canceled -= instance.OnRun;
        }

        public void RemoveCallbacks(ICharactercontrolActions instance)
        {
            if (m_Wrapper.m_CharactercontrolActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharactercontrolActions instance)
        {
            foreach (var item in m_Wrapper.m_CharactercontrolActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharactercontrolActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharactercontrolActions @charactercontrol => new CharactercontrolActions(this);
    public interface ICharactercontrolActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
