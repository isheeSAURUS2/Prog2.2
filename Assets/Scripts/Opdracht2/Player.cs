using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    [SerializeField] private float rotationSpeed = 5;
    public int Health
    {
        get { return Health = 0; }
        set { Health = 10; }
    }
    public int Speed
    {
        get { return Speed = 0; }
        set { Speed = 10; }
    }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public override void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) TakeDamage();
    }
}
