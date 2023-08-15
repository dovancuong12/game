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
        Debug.Log(rb.velocity);
        //Debug.Log(movement.y);

        if(movement.x == 0 && movement.y == 1)
        {
            if(isMoving)
            {
                animator.Play("kinght-walk-after");
            }
            else{
                animator.Play("kinght-Idle-after");
            }
        }
        
        if(movement.x == 0 && movement.y == -1) 
        {
            if(isMoving)
            {
                animator.Play("kinght-walk-before");
            }
            else{
                animator.Play("kinght-Idle-before");
            }
        }
        
        if(movement.x == 1 && movement.y == 0)
        {
            if(isMoving)
            {
                animator.Play("kinght-walk-right");
            }
            else{
                animator.Play("kinght-Idle-right");
            }
        }
        
        if(movement.x == -1 && movement.y == 0)
        {
            if(isMoving)
            {
                animator.Play("kinght-walk-left");
            }
            else{
            animator.Play("kinght-Idle-left"); 
            }
        }
    }
}