using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    private int health = 10;
    private int speed = 5;  

    public int Health
    {
        get { return health; }
        set { health = Mathf.Max(0, value); } 
    }

    public int Speed
    {
        get { return speed; }
        set { speed = Mathf.Max(0, value); }
    }

    public virtual void Move()
    {
        if (Health > 0)
        {
            transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage()
    {
        Health--; // Reduce health when taking damage
    }
}

public interface IMovable
{
    int Speed { get; }
    void Move();
}

public interface IDamagable
{
    int Health { get; }
    void TakeDamage();
}
