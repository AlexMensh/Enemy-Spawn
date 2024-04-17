using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    [SerializeField] private float _spawnDelay;
    [SerializeField] private int _maxEnemies;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_spawnDelay);

        for (int i = 0; i < _maxEnemies; i++)
        {
            int spawnerIndex = Random.Range(0, _spawnPoints.Count);

            _spawnPoints[spawnerIndex].SpawnEnemy();

            yield return wait;
        }
    }
}