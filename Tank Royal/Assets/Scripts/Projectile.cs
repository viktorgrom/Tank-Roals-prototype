using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int _damage = 5;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private string _myTag = "";

    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Tank>() != null && collision.gameObject.tag != _myTag)
        {
            collision.gameObject.GetComponent<Tank>().TakeDamage(_damage);
            gameObject.SetActive(false);
        }
    }
}