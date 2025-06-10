using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public bool grounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            myrigidbody.linearVelocity = Vector2.left * 10;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            myrigidbody.linearVelocity = Vector2.right * 10;
        }

        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
            myrigidbody.linearVelocity = Vector2.up * 10;
            }
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position, 2.45f, Vector2.down, 0.05f);
    }
}
