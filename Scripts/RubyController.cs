using System.Collections;
using System.Collections.Generic;
using Managers.ManagerInterfaces;
using Ruby2DInterfaces;
using UnityEngine;
using Zenject;

public class RubyController : MonoBehaviour, IRubyController
{
    [Inject] protected IContentManager cm;
    
    public float speed = 3.0f;
    public int maxHealth = 5;
    private int currentHealth;
    public int health { get { return currentHealth; } }
    public float timeInvincible = 2.0f;
    private bool isInvincible;
    private float invincibleTimer;

    public GameObject projectilePrefab;
    
    // instead of using transform, use RigidBody to stop
    // jittering - caused by physics engine
    // RigidBody2D component has to be added before use
    Rigidbody2D rigidbody2d;
    Animator animator;
    Vector2 lookDirection = new Vector2(1,0);
    
    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 60;
        
        // get the rigidbody component
        rigidbody2d = GetComponent<Rigidbody2D>();
        
        // set the current health value to the declared max
        currentHealth = maxHealth;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        
        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", lookDirection.magnitude);
        
        Vector2 position = rigidbody2d.position;
        position = position + speed * move * Time.deltaTime;

        rigidbody2d.MovePosition(position);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            LaunchProjectile();
        }
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

//            animator.SetTrigger("Hit");
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

    void LaunchProjectile()
    {
        GameObject projectileObject =
            Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(lookDirection, 300);
        
        animator.SetTrigger("Launch");
    }

    public int Increment(int num)
    {
        return ++num;
    }
    
    public int InjectedCMIncrement(int num)
    {
        return cm.Increment(num);
    }
}
