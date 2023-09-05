using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody;
    private float horizontal;
    private float speed = 8f;
    private float jumpPower = 4.5f;
    private bool isFacingRight = true;
    private bool canJump = false;
    private bool isDead = false;

    private void Start() {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Flip();
    }

    void FixedUpdate()
    {
        if(!isDead)
        {
            rigidbody.velocity = new Vector2(horizontal * speed, rigidbody.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }

        
    }

    void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void Jump()
    {
        if(canJump)
        {
            rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        canJump = !canJump;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canJump = !canJump;
    }

    
}
