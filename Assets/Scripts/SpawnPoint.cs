using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private List<TargetPoint> _targets;
    [SerializeField] private Enemy enemyPrefab;

    public void SpawnEnemy()
    {
        int targetIndex = Random.Range(0, _targets.Count);

        Enemy newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.GetTarget(_targets[targetIndex]);
    }
}