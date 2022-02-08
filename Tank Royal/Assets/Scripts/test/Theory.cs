using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theory : MonoBehaviour
{
    IMovable player = new Player();
    IMovable vehicle = new Vehicle();

    void Start()
    {
        player.Move();
        vehicle.Move();
    }

    
}

public interface IMovable
{
    float Speed { get; }

    void Move();
}

public interface IDamageble
{
    void TakeDamage(int damage);
}

public class Player : IMovable, IDamageble
{
    public float Speed { get; set; }
    private int _health = 100;

    public void Move()
    {
        Debug.Log("Player move");
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}

public class Vehicle: IMovable
{
    public float Speed { get; } = 20f;

    public void Move()
    {
        Debug.Log($"Car move {Speed}");
    }
}
