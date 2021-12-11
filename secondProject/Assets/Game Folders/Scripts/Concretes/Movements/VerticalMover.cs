using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Controllers;
using secondProject.Abstracts.Movements;
using secondProject.Abstracts.Controllers;


namespace secondProject.Movements
{
    public class VerticalMover : IMover
    {
        IEntityController _entityController;
        float _moveSpeed;

        public VerticalMover(IEntityController entityController)
        {
            _entityController = entityController;
            //_moveSpeed = entityController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)
        {
            _entityController.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }
    }
}

