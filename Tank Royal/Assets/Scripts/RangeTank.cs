using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeTank : ShootableTank
{
    [SerializeField] private float _distanceToPlayer = 5f;
    private float _timer;
    private Transform target;

    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<PlayerTank>().transform;
    }
    protected override void Move()
    {
        transform.Translate(Vector3.down * _movementSpeed * Time.deltaTime);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > _distanceToPlayer)
            Move();

        SetAngle(target.position);

        if(_timer <= 0)
        {
            Shoot();
            _timer = _reloadTime;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
