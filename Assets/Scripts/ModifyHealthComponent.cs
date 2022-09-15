using UnityEngine;

namespace DefaultNamespace
{
    public class ModifyHealthComponent : MonoBehaviour
    {
        [SerializeField] private int _hpDelta;

        public void ApplyHp(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();
            if (healthComponent !=  null)
            {
                healthComponent.ModifyHealth(_hpDelta);
            }
        }
    }
}