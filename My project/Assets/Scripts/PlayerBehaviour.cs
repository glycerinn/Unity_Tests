using System.ComponentModel;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerBehaviour : Player
{
    public Rigidbody2D myrigidbody;
    private float horizontalMove;
    private bool facingRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetAxis("Horizontal") < 0)
        {
            MoveLeft();
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            MoveRight();
        }

        if (!facingRight && Input.GetAxis("Horizontal") > 0)
        {
            Flip();
        }
        else if (facingRight && Input.GetAxis("Horizontal") < 0)
        {
            Flip();
        }
        
        
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }


    private void MoveLeft()
    {
        myrigidbody.AddForce(Vector2.left * 0.3f, ForceMode2D.Impulse);
    }

    private void MoveRight()
    {
        myrigidbody.AddForce(Vector2.right * 0.3f, ForceMode2D.Impulse);
    }

}
