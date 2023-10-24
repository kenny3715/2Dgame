using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 20;
    public float JumpForce = 1;
    private Rigidbody2D rbody2D;
    private bool isOnGround;
    private Animator animator;
    //public bulletController bullet;
    public int dir = 0;
    //public Transform LauchOffset;

    void Start()
    {
        rbody2D = gameObject.GetComponent<Rigidbody2D>();
        isOnGround = false;
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        Debug.Log(dirx);
        if (dirx > 0)
            dir = 1;
        else if (dirx < 0)
            dir = -1;
        else
            dir = dir;
       
        rbody2D.velocity = new Vector2(dirx * speed, rbody2D.velocity.y);
        

        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            rbody2D.velocity += new Vector2(0, JumpForce);
        }
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetInteger("state", 2);
            
            
        }
        else if (dirx != 0)
        {
            animator.SetInteger("state", 1);
        }
        else
        {
            animator.SetInteger("state", 0);
        }
        if (dirx * transform.localScale.x < 0)
        {
            this.transform.localScale = new Vector3(-1 * this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnGround = false;
    }
}
