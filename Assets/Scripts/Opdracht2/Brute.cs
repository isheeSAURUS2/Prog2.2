using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    
    void Start()
    {
        Speed = 1;
        Health = 10;
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
