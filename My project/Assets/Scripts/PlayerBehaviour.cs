using System.ComponentModel;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerBehaviour : Player
{
    public Rigidbody2D myrigidbody;
    public bool facingRight;
    public Vector2 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        facingRight = true;
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        float Vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalMove, 0f, Vertical).normalized;

        // if (Input.GetAxis("Horizontal") < 0)
        // {
        //     MoveLeft();
        // }
        // else if (Input.GetAxis("Horizontal") > 0)
        // {
        //     MoveRight();
        // }

        if (!facingRight && Input.GetAxis("Horizontal") > 0)
        {
            Flip();
        }
        else if (facingRight && Input.GetAxis("Horizontal") < 0)
        {
            Flip();
        }

        myrigidbody.AddForce(moveDirection * 0.1f, ForceMode2D.Impulse);
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }


    // private void MoveLeft()
    // {
    //     myrigidbody.AddForce(Vector2.left * 0.07f, ForceMode2D.Impulse);
    // }

    // private void MoveRight()
    // {
    //     myrigidbody.AddForce(Vector2.right * 0.07f, ForceMode2D.Impulse);
    // }

}
