// GENERATED AUTOMATICALLY FROM 'Assets/_MyAssets/Sctips/PlayerActionInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionInputs"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""01d68f51-7bef-45b3-8ab3-839665ad5e4b"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5fd6bd7a-c00e-4fae-9116-fd13a259a758"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74caf6e6-68e5-4f0e-9d32-f2934d79ab6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideway1"",
                    ""id"": ""6f44023f-497c-4824-809b-f33ff1804a8e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c6b3c849-11e5-41bc-99f5-31da9b33a5b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""07f68dcc-9c6c-48b2-9cb2-24666445fd5a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideway2"",
                    ""id"": ""6eb4c133-4c2a-4f0d-9ed2-ce9043f8d877"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6e91d321-7cb8-47d9-aeae-fd4ba8e31d93"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5fd622f4-0e3e-4be0-8041-32ab80215438"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideway1"",
                    ""id"": ""7643adb5-de72-4871-be73-52590fd26e74"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""230d8797-a1a8-4568-9376-d74ebd03fd3a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eed313d8-4fff-43eb-92f2-14c39271b0bf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideway2"",
                    ""id"": ""b11d38c3-a227-420b-83cb-8b5f4d4257ec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""79cb5dc4-4d74-4650-97b4-04bd63f90d26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d08e30a3-f084-4471-b190-f34f24e7be8c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Horizontal = m_Move.FindAction("Horizontal", throwIfNotFound: true);
        m_Move_Vertical = m_Move.FindAction("Vertical", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Horizontal;
    private readonly InputAction m_Move_Vertical;
    public struct MoveActions
    {
        private @PlayerActionInputs m_Wrapper;
        public MoveActions(@PlayerActionInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Move_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Move_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
}
