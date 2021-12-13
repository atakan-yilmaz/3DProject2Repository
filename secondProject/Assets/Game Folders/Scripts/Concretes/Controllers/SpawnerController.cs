using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Managers;
using secondProject.Enums;


namespace secondProject.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [Range (0.1f, 5f)][SerializeField] float _min = 0.1f;
        [Range(6f, 10f)][SerializeField] float _max = 10f;
        [SerializeField] float _maxSpawnTime;

        float _currentSpawnTime = 0f;

        private void OnEnable()
        {
            GetRandomMaxTime();
        }

        void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _maxSpawnTime)
            {
                Spawn();
                _currentSpawnTime = 0f;
            }
        }

        void Spawn() //dusman spawnlamasi icin 
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool(enemyType:(EnemyEnums)Random.Range(0, 4));
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);

            GetRandomMaxTime();
            _currentSpawnTime = 0f;
        }

        private void GetRandomMaxTime() //rastgele dusman spawnlanmasi icin yonlendirici kod
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
}
