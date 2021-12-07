using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using secondProject.Inputs;
using secondProject.Movements;
using secondProject.Abstracts.Inputs;


namespace secondProject.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _jumpForce = 1300f;
        [SerializeField] float _moveBoundary = 4.5f;
       

        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jump;
        IInputReader _input;
        float _horizontal;
        bool _isJump;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary; 

        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
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
        }

        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontal);

            if (_isJump)
            {
                _jump.TickFixed(_jumpForce);
            }

            _isJump = false;
        }
    }
}

