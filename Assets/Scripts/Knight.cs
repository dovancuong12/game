using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knight : MonoBehaviour
{
    public int HP, maxHP;
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject door;
    public GameObject player;
    public GameObject respawnPoint,respawnPoint1 ;
    private bool isOpen = false;

    bool isMoving;
    public void Update()
    {
        Move();
        MoCua();
    }
    private void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        var movement = new Vector2(moveHorizontal, moveVertical).normalized;
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
    private void MoCua()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isOpen)
            {  // Mở cửa
                door.transform.rotation = Quaternion.Euler(0, -86, 0);
                isOpen = true;
            }
            else
            { // Đóng cửa
                door.transform.rotation = Quaternion.Euler(0, 0, 0);
                isOpen = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Scene4"))
        {
            //gameObject.SetActive(false);
            SceneManager.LoadScene("House4");
        }
        if(other.gameObject.CompareTag("zone"))
        {
            //gameObject.SetActive(false);
            SceneManager.LoadScene("Scene");
            // player.transform.position = respawnPoint.transform.position;
        }

        if(other.gameObject.CompareTag("nexten"))
        {
            gameObject.SetActive(false);
            player.transform.position = respawnPoint.transform.position;
            gameObject.SetActive(true);
        }
        if(other.gameObject.CompareTag("nextduoi"))
        {
            gameObject.SetActive(false);
            player.transform.position = respawnPoint1.transform.position;
            gameObject.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("Scene2"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}