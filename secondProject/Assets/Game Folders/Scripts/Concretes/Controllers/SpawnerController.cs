using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace secondProject.Controllers
{
    public class SpawnerController : MonoBehaviour
    {

        [SerializeField] EnemyController _enemyPrefab;
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
            EnemyController newEnemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;

            GetRandomMaxTime();
            _currentSpawnTime = 0f;
        }

        private void GetRandomMaxTime() //rastgele dusman spawnlanmasi icin yonlendirici kod
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
}
