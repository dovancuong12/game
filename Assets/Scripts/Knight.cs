using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public int HP, maxHP;
    public float speed, rotateSpeed;
    public Rigidbody2D rb;
    public Animator animator;

    bool isMoving;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        var movement = new Vector2(moveHorizontal, moveVertical).normalized;
        //Debug.Log(movement);
        rb.velocity = movement.normalized * speed;
        isMoving = movement != Vector2.zero;

        if (isMoving)
        {
            if (movement == Vector2.up)
            {
                animator.Play("kinght-walk-after");
            }
            else if (movement == Vector2.down)
            {
                animator.Play("kinght-walk-before");
            }
            else if (movement == Vector2.right)
            {
                animator.Play("kinght-walk-right");
            }
            else if (movement == Vector2.left)
            {
                animator.Play("kinght-walk-left");
            }
        }
        else
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("kinght-walk-after"))
            {
                animator.Play("kinght-Idle-after");
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("kinght-walk-before"))
            {
                animator.Play("kinght-Idle-before");
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("kinght-walk-right"))
            {
                animator.Play("kinght-Idle-right");
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("kinght-walk-left"))
            {
                animator.Play("kinght-Idle-left");
            }
        }
    }
}