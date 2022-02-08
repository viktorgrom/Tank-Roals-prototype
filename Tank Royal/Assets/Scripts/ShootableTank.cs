using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootableTank : Tank
{
    [Header("Shoot")]
    [SerializeField] private GameObject _projectile;
    [SerializeField] private string _projectileTag;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] protected float _reloadTime = 0.5f;
    private ObjectPooler _objectPooler;

    protected override void Start()
    {
        base.Start();
        _objectPooler = ObjectPooler.Instance;
    }

    protected void Shoot()
    {
        _objectPooler.SpawnFromPool(_projectileTag, _shootPoint.position, transform.rotation);
    }
}
