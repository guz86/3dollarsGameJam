using UnityEngine;

namespace DefaultNamespace
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] private int pitchPower = 175;
        
        private Rigidbody _rigidbody;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void OnSpikePitch()
        {
            _rigidbody.AddForce(new Vector3(transform.position.x,
                pitchPower, 0));
        }
        
        /*[SerializeField] private float _speed = 50f;

        private Vector2 _direction;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }

        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector3(_direction.x * _speed, _direction.y * _speed, 0);
        }*/
    }
}