using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> targets;

    [SerializeField] private Enemy enemyPrefab;

    public void SpawnEnemy()
    {
        int targetIndex = Random.Range(0, targets.Count);

        Enemy newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.SetTarget(targets[targetIndex]);
    }
}