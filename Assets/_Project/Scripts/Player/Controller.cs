using _Project.Scripts;
using Helpers;
using UnityEngine;
using VContainer;

namespace Player
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private Snake _snake;
        [Inject] private InputHandler _inputHandler;
        [Inject] private PlayerCamera _playerCamera;
        
        [SerializeField] private Transform _cursor;
        private Plane _playerPlane;

        private void Awake()
        {
            _playerPlane = new Plane(Vector3.up, Vector3.zero);
        }

        private void Update()
        {
            if (_inputHandler.IsLMBPressed)
            {
                MoveCursor();
                _snake.LookAt(_cursor.position);
            }
        }

        private void MoveCursor()
        {
            Ray ray = _playerCamera.GetCurrentCamera().ScreenPointToRay(_inputHandler.GetMousePosition());
            _playerPlane.Raycast(ray, out float distance);
            Vector3 point = ray.GetPoint(distance);
            _cursor.transform.position = point;
        }
    }
}