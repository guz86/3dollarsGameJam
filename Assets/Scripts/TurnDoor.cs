using UnityEngine;

namespace DefaultNamespace
{
    // вентилятор
    public class TurnDoor : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 120f;
        private Vector3 currentEulerAngles;
        private float y = -1;

        private void FixedUpdate()
        {
            currentEulerAngles += new Vector3(0, y, 0) * (Time.fixedDeltaTime * _rotationSpeed);
            transform.localEulerAngles = currentEulerAngles;
        }
    }
}