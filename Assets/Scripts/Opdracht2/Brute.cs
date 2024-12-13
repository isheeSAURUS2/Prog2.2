using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    public int Health
    {
        get { return Health = 0; }
        set { Health = 10; }
    }
    void Start()
    {
        speed = 1.5f;
        
    }
    private void Update()
    {
        Move();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) TakeDamage();
    }
}
