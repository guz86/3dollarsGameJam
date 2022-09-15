using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ProgressBarWidget : MonoBehaviour
    {
        [SerializeField] private Image _bar;
        [SerializeField] private Hero _hero;
        [SerializeField]private float _maxHealth = 10f;
        
        
        private HealthComponent _health;

        private void Start()
        {
           // _hero = GetComponent<Hero>();
            _health = _hero.GetComponent<HealthComponent>();
        }


        private void Update()
        {
      //     _bar.fillAmount =_health.Health / _maxHealth;
        }

         public void SetHealthProgress()
         {
             _bar.fillAmount =_health.Health / _maxHealth;
        }
    }
}