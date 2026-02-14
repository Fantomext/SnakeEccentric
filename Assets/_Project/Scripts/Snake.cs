using UnityEngine;

namespace _Project.Scripts
{
    public class Snake : MonoBehaviour
    {
        [SerializeField] private Transform _head;
        [SerializeField] private Transform _directioinPoint;
        
        [SerializeField] private float _speed = 2f;
        [SerializeField] private float _rotateSpeed = 90f;

        private void Update()
        {
            Rotate();
            Move();
        }

        public void LookAt(Vector3 position)
        {
            transform.LookAt(position);
        }

        private void Move()
        {
            transform.position += transform.forward * Time.deltaTime * _speed;
        }

        private void Rotate()
        {
            float diffY = _directioinPoint.eulerAngles.y - _head.eulerAngles.y;
            
            float maxAngel = Time.deltaTime * _rotateSpeed;
            float rotateY = Mathf.Clamp(diffY, -maxAngel, maxAngel);
            
            _head.Rotate(0, rotateY,0);
        }
    }
}