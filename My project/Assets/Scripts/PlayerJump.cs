using UnityEngine;

public class PlayerJump : PlayerBehaviour
{
    private bool grounded;
    private float jumpForce = 17;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
                animator.SetBool("Jumping", true);
            }
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position - transform.right * 0.01f, 3f, Vector2.down, 0.05f);

    }

    private void Jump()
    {
        myrigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
