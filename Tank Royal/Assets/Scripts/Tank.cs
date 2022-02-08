using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Tank : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 30;
    [SerializeField] protected float _movementSpeed = 3f;
    [SerializeField] protected float _angleOffset = 90f;
    [SerializeField] protected float _rotationSpeed = 7f;
    [SerializeField] private int _points = 0;

    protected Rigidbody2D _rigidbody;
    [SerializeField] protected int _currentHeath;

    protected UI _ui;

    protected virtual void Start()
    {
        _currentHeath = _maxHealth;
        _rigidbody = GetComponent<Rigidbody2D>();
        _ui = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
    }

    public virtual void TakeDamage(int damage)
    {
        _currentHeath -= damage;
        if (_currentHeath <= 0)
        {
            Stats.Score += _points;
            _ui.UpdateScoreLevel();
            Destroy(gameObject);
        }
            

        print(_currentHeath);
    }

    protected abstract void Move();

    protected void SetAngle(Vector3 target)
    {
        Vector3 deltaPosition = target - transform.position;
        float angleZ = Mathf.Atan2(deltaPosition.y, deltaPosition.x) * Mathf.Rad2Deg;
        Quaternion angle = Quaternion.Euler(0f, 0f, angleZ + _angleOffset);
        transform.rotation = Quaternion.Lerp(transform.rotation, angle, Time.deltaTime * _rotationSpeed);
    }
}
