using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    private bool grounded;
    private float jumpForce = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal")<0)
        {
            MoveLeft();
        }

        if (Input.GetAxis("Horizontal")>0)
        {
            MoveRight();
        }

        if (grounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position, 2.45f, Vector2.down, 0.05f);
    }

    private void Jump()
    {
        myrigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void MoveLeft()
    {
        myrigidbody.AddForce(Vector2.left * 10, ForceMode2D.Force);
    }

    private void MoveRight()
    {
        myrigidbody.AddForce(Vector2.right * 10, ForceMode2D.Force);
    }
}
