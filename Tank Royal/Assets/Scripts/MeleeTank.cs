using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeTank : Tank
{
    [SerializeField] private int _damage = 5;
    private Transform _target;
    private float _timer;
    private float _hitCoolDown = 1f;

    protected override void Start()
    {
        
        _target = FindObjectOfType<PlayerTank>().transform;
        base.Start();
    }


    protected override void Move()
    {
        transform.Translate(Vector3.down * _movementSpeed * Time.deltaTime);
    }

    private void Update()
    {
        if(_target != null)
        {
            if(_timer <= 0)
            {
                Move();
                SetAngle(_target.position);
            }
            else
            {
                _timer -= Time.deltaTime;
            }
            
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerTank>() != null && _timer <= 0)
        {
            collision.gameObject.GetComponent<PlayerTank>().TakeDamage(_damage);
            _timer = _hitCoolDown;
        }
    }
}
