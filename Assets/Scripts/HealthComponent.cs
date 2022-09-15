using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private float _health = 10f;
        [SerializeField] private UnityEvent _OnDamage;
        [SerializeField] private UnityEvent _OnWallDamage;
        [SerializeField] private UnityEvent _OnHeal;
        [SerializeField] private UnityEvent _OnDeath;
        private Rigidbody _rigidbody;
        private Hero _hero;

        public float Health => _health;

        private void Awake()
        {
            _hero = GetComponent<Hero>();
            _rigidbody = _hero.GetComponent<Rigidbody>();
        }

        public void ModifyHealth(float healthDelta)
        {
            _health += healthDelta;


            if (healthDelta < 0)
            {
                _OnDamage?.Invoke();
            }

            if (healthDelta > 0)
            {
                _OnHeal?.Invoke();
            }


            if (_health <= 0)
            {
                _OnDeath?.Invoke();
            }
        }

        public void ModifyWallDamage(float healthDelta)
        {
            // в зависимости от скорости выставлять - к Hp
            if (healthDelta < 0 && (_rigidbody.velocity.x > 4))
            {
                _health += healthDelta;
                _OnWallDamage?.Invoke();
            }
        }

        // public void ModifyScrewDamage(float healthDelta)
        // {
        //     // в зависимости от скорости выставлять - к Hp
        //     if (healthDelta < 0)
        //     {
        //         _health += healthDelta;
        //         _OnWallDamage?.Invoke();
        //     }
        // }
    }
}