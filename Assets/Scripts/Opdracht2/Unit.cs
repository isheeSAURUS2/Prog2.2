using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public float speed = 5f;
    public float health = 5f;
    public virtual void Move()
    {
        if (health > 0f)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if(health < 0f)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage()
    {
        health--;
    }
}
public interface IMovable
{ 
    void Move();
}
public interface IDamagable
{
    int Health { get; }
    void TakeDamage();
}