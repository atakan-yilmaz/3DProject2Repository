using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Movements;
using secondProject.Managers;
using secondProject.Abstracts.Controllers;
using secondProject.Enums;

namespace secondProject.Controllers
{
    public class EnemyController : MyCharacterController, IEntityController
    {
        [SerializeField] float _maxLifeTime = 5f;
        [SerializeField] EnemyEnums _enemyEnum;

        VerticalMover _mover;

        float _currentLifeTime = 0f;

        public EnemyEnums EnemyType => _enemyEnum;

        private void Awake()
        {
            _mover = new VerticalMover(this);
        }

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;
            if (_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0f;
                KillYourself();
            }
        }

        private void FixedUpdate()
        {
            _mover.FixedTick();
        }
        void KillYourself()
        {
            EnemyManager.Instance.SetPool(this);
        }
    }
}

