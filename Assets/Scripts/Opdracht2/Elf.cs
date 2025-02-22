using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    private Renderer elfRenderer;
    float timer;
    
    void Start()
    {
        Health = 3;
        elfRenderer = GetComponent<Renderer>();
        Speed = 3;
    }

    void Update()
    {
        Move();
        timer += Time.deltaTime;
        if (timer > 3)
        {
            StartCoroutine("ToggleVisibility");
            timer = 0;
        }
    }
    private void ToggleVisibility()
    {
        elfRenderer.enabled = !elfRenderer.enabled;
    }
    private IEnumerator VisibilityAbility()
    {
        ToggleVisibility();
        yield return new WaitForSeconds(0.5f);
        ToggleVisibility();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) TakeDamage();
    }
}
