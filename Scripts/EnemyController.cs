using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool isVertical;
    public bool isBroken = true;
    public ParticleSystem smokeEffect;
    private Rigidbody2D rigidbody2d;
    
    // time before reversing enemy direction
    public float changeTime = 3.0f;
    private float timer;
    private int direction = 1;

    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBroken)
        {
            return;
        }
        
        timer -= Time.deltaTime;
        
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
        
        Vector2 position = rigidbody2d.position;

        if (isVertical)
        {
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
            position.y = position.y + speed * Time.deltaTime * direction;
        }
        else
        {
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
            position.x = position.x + speed * Time.deltaTime * direction;
        }
        rigidbody2d.MovePosition(position);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();

        if (player != null)
            player.ChangeHealth(-1);
    }

    public void Fix()
    {
        isBroken = false;
        // this removes the rigid body from the physics system simulation
        // meaning it will no longer collide or hurt the Player Character 
        rigidbody2d.simulated = false;
        
        // remove the smoke effect
        smokeEffect.Stop();
        Destroy(smokeEffect.gameObject);
    }
}
