using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Helpers
{
    public class InputHandler : IDisposable
    {
        private PlayerInput _playerInput;
        
        public bool IsLMBPressed { get; private set; }

        public InputHandler()
        {
            _playerInput = new PlayerInput();
        }

        public void Init()
        {
            _playerInput.Enable();
            
            _playerInput.Player.LMB.started += LMBPress;
            _playerInput.Player.LMB.canceled += LMBCanceled;
        }

        private void LMBCanceled(InputAction.CallbackContext obj)
        {
            IsLMBPressed = false;
        }

        private void LMBPress(InputAction.CallbackContext obj)
        {
            IsLMBPressed = true;
            Debug.Log("Press");
        }

        public Vector3 GetMousePosition()
        {
            Vector2 mousePos = _playerInput.Player.MousePosition.ReadValue<Vector2>();
            return new Vector3(mousePos.x, mousePos.y, 0);
        }

        public void Dispose()
        {
            _playerInput.Player.LMB.started -= LMBPress;
            _playerInput.Player.LMB.canceled -= LMBCanceled;
        }
        
    }
}