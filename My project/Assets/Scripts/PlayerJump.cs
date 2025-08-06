using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : PlayerBehaviour
{
    private bool grounded;
    private float jumpForce = 16;
    public int totalJump;
    private InputAction jump;

    private void Awake()
    {
       playerControls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        jump = playerControls.Player.Jump;
        jump.Enable();
    }

    private void OnDisable()
    {
        jump.Disable();
    }

    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        grounded = true;
    }

    void Update()
    {
        if (jump.triggered)
        {
            Jump();
        }
        animator.SetBool("Jumping", !grounded);
    }

    public void Jump()
    {
        if (grounded)
        {
            totalJump = 2;
        }
        if (totalJump > 0)
        {
            totalJump = totalJump - 1;
            myrigidbody.linearVelocity = new Vector2(myrigidbody.linearVelocityX, jumpForce);
            animator.SetBool("Jumping", true);
        }        
    }

    void FixedUpdate()
    {
        grounded = Physics2D.CircleCast(transform.position - transform.right * 0.01f, 3f, Vector2.down, 0.05f);
    }

    
}
