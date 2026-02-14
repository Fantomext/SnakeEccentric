using UnityEngine;

namespace Player
{
    public class PlayerCamera : MonoBehaviour
    {
        [SerializeField] private Camera _camera;   
        public Camera GetCurrentCamera()
        {
            return _camera;
        }
    }
}