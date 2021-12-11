using secondProject.Abstracts.Controllers;
using secondProject.Abstracts.Inputs;
using secondProject.Inputs;
using secondProject.Managers;
using secondProject.Movements;
using secondProject.Abstracts.Movements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace secondProject.Controllers
{
    public class PlayerController : MonoBehaviour, IEntityController
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _jumpForce = 1300f;
        [SerializeField] float _moveBoundary = 4.5f;
       
        IMover _mover;
        JumpWithRigidbody _jump;
        IInputReader _input;
        float _horizontal;
        bool _isJump;
        bool _isDead = false;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary; 
        private void Awake()
        {
            _mover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontal = (_input.Horizontal);

            if (_input.IsJump)
            {
                _isJump = true;
            }

            if (_isDead) return;    
        }
        private void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jump.FixedTick(_jumpForce);
            }

            _isJump = false;
        }

        void OnCollisionEnter(Collision other)
        {
            IEntityController entityController = other.collider.GetComponent<IEntityController>();

            if (entityController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }
        }
    }
}

