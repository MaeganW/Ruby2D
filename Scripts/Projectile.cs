using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    
    // Awake is called immediately when the object is created
    // Since we are instantiating the projectile, it doesn't call Start()
    // immediately but on the next frame, leaving the rigidbody variable null
    // when the Launch fn below is called - so switch to Awake() to fix this
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
        
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody.AddForce(direction * force);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController controller = other.collider.GetComponent<EnemyController>();
        if (controller != null)
        {
            controller.Fix();
        }
        
        Destroy(gameObject);
    }
}
