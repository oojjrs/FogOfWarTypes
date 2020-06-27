using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Script.FogB
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
            {
                var v = GetComponent<PlayerInput>().actions["Move"].ReadValue<Vector2>();
                GetComponent<CharacterController>().Move(new Vector3(v.x, 0, v.y) * Time.deltaTime * _speed);
            }
        }
    }
}
