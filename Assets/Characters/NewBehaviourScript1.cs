using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed = 7f;
    private Rigidbody2D rb;
    public float horizontal;
    private bool flip = true;
    public Animator animator;
    private bool flipRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Uptade()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed , rb.velocity.y);
        animator.SetFloat("moveX", Mathf.Abs (horizontal));
        if (horizontal > 0 && !flipRight)
        {
            Flip();
        }
        else if (horizontal < 0 && flipRight)
        {
            Flip();
        }
    }
    void Flip()
    {
        flip = !flip;
        Vector3 theScale = transform.localScale ;
        theScale.x = theScale.x * (-1);
        transform.localScale = theScale;
    }
}
 