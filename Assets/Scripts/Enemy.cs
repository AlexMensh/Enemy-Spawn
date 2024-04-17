using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void SetTarget(GameObject target)
    {
        _target = target.transform;
    }
}