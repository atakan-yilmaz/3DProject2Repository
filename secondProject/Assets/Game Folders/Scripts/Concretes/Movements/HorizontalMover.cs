using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Controllers;
using secondProject.Abstracts.Controllers;
using secondProject.Abstracts.Movements;


namespace secondProject.Movements
{
    public class HorizontalMover : IMover
    {
        IEntityController _playerController;
        float _moveSpeed;
        float _moveBoundary;

        public HorizontalMover(IEntityController entityController)
        {
            _playerController = entityController;
            _moveSpeed = entityController.MoveSpeed;
            _moveBoundary = entityController.MoveBoundary;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, min: -_moveBoundary, max: _moveBoundary);
            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, z: 0f);
        }
    }
}

