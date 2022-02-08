using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerTank : ShootableTank
{
    private float _timer;
    [SerializeField] private List<Guns> _guns;
    protected override void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        _rigidbody.velocity = direction.normalized * _movementSpeed;
    }

    public override void TakeDamage(int damage)
    {
        _currentHeath -= damage;
        _ui.UpdateHp(_currentHeath);

        if(_currentHeath <= 0)
        {
            Stats.ResetAllStats();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void Update()
    {
        Move();

        SetAngle(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if(_timer <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
                _timer = _reloadTime;
            }
        }
        else
        {
            _timer -= Time.deltaTime;
        }
        
    }
}
