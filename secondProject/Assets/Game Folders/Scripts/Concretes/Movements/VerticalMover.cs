using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Controllers;

namespace secondProject.Movements
{
    public class VerticalMover 
    {
        EnemyController _enemyController;
        float _moveSpeed;
        public VerticalMover(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = _enemyController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            _enemyController.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }
    }
}

