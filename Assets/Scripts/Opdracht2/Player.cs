using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    [SerializeField] private float rotationSpeed = 5;
    
    void Start()
    {
        Speed = 5;
        Health = 5;
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public override void Move()
    {
        transform.position += transform.forward * Speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) TakeDamage();
    }
}
