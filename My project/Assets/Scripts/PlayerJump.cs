using UnityEditor.ShaderGraph;
using UnityEngine;

public class PlayerJump : PlayerBehaviour
{
    private bool grounded;
    private float jumpForce = 16;
    public int totalJump;
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
            totalJump = 2;
        }
        if (totalJump > 0 && Input.GetButtonDown("Jump"))
        {
            totalJump = totalJump - 1;
            myrigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("Jumping", true);
        }
        
        animator.SetBool("Jumping", !grounded);
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position - transform.right * 0.01f, 3f, Vector2.down, 0.05f);
    }
}
