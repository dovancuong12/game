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
        // Debug.Log(movement);
        rb.velocity = movement.normalized * speed;
        isMoving = movement != Vector2.zero;

        if(isMoving)
        {
        //đi về sau
            if(movement.x == 0 && movement.y == 1 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == 0.71 && movement.y == 0.71)
            {
                animator.Play("kinght-walk-after");
            }
        }
        else if(movement.x == 0 && movement.y == 1 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == 0.71 && movement.y == 0.71)
        {
            animator.Play("kinght-Idle-after");
        }

        if(isMoving)
        {
        //đi về trước
            if(movement.x == 0 && movement.y == -1 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == -0.71 && movement.y == -0.71) 
            {
                animator.Play("kinght-walk-before");
            }
        }
        else if(movement.x == 0 && movement.y == -1 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == -0.71 && movement.y == -0.71) 
        {
            animator.Play("kinght-Idle-before");
        } 

        if(isMoving)
        {
         //đi về phải
            if(movement.x == 1 && movement.y == 0 || movement.x != 0 && movement.x == 0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == 0.71 && movement.y == -0.71)
            {
                animator.Play("kinght-walk-right");
            }
        }
        else if(movement.x == 1 && movement.y == 0 || movement.x != 0 && movement.x == 0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == 0.71 && movement.y == -0.71)
        {
            animator.Play("kinght-Idle-right");
        }

        if(isMoving)
        {
         //đi về trái
            if(movement.x == -1 && movement.y == 0 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == -0.71 && movement.y == -0.71)
            {
                animator.Play("kinght-walk-left");
            }
        }
        else if(movement.x == -1 && movement.y == 0 || movement.x != 0 && movement.x == -0.71 && movement.y == 0.71 || movement.x != 0 && movement.x == -0.71 && movement.y == -0.71)
        {
            animator.Play("kinght-Idle-left");
        }

    }
}