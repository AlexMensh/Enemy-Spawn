using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> _wayPoints;

    [SerializeField] private Transform _target;

    [SerializeField] private float _speed;

    private int _wayPointIndex;

    private void Start()
    {
        SetWayPoint();
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_wayPointIndex].transform.position)
        {
            SetWayPoint();
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_wayPointIndex].transform.position, _speed * Time.deltaTime);
    }

    private void SetWayPoint()
    {
        _wayPointIndex = Random.Range(0, _wayPoints.Count);
    }
}