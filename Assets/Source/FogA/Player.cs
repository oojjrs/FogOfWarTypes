using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Script.FogA
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    public class Player : MonoBehaviour
    {
        public float _speed;
        private bool _moving;

        public void OnMove(InputAction.CallbackContext context)
        {
            _moving = context.performed;
        }

        private void Update()
        {
            if (_moving)
                GetComponent<CharacterController>().Move(GetComponent<PlayerInput>().actions["Move"].ReadValue<Vector2>() * Time.deltaTime * _speed);
        }
    }
}
