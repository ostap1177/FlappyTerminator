using System.Collections;
using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private WaitForSeconds _waitForSeconds;
    private Coroutine _spawning;

    private void Awake()
    {
        Initialaze(_enemyPrefab);
        _waitForSeconds = new WaitForSeconds(_secondBetweenSpawn);

        Spawn();
    }

    private void Spawn()
    {
        if (_spawning != null)
        {
            StopCoroutine(_spawning);
        }

        _spawning = StartCoroutine(DelaySpawn());
    }

    private IEnumerator DelaySpawn()
    {
        while (true)
        {
            yield return _waitForSeconds;

            if (TryGetObject(out GameObject enemy) == true)
            {
                float spawnPositionY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
                enemy.SetActive(true);
                enemy.transform.position = spawnPoint;

                DisableObjectAbroadScreen();
            }
            else
            {
                Initialaze(_enemyPrefab);
            }
        }
    }
}

