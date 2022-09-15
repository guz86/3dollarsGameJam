using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    // [SerializeField] private Hero _hero;
    //
    // public void WASD(InputAction.CallbackContext context)
    // {
    //     var direction = context.ReadValue<Vector2>();
    //     _hero.SetDirection(direction);
    // }

    [SerializeField] private float _speed = 20f;


    private Rigidbody _rigidbody;
    private float movementX;
    private float movementY;

    private float _damageVelocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void OnWASD(InputValue _inputValue)
    {
        var movementVector = _inputValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector3(movementX, movementY, 0);
        _rigidbody.AddForce(movement * _speed);
        //Debug.Log(_rigidbody.velocity.x > 8);
    }
    


}