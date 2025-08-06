using System.ComponentModel;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.InputSystem;

public class PlayerBehaviour : Player
{
    public Rigidbody2D myrigidbody;
    public bool facingRight;
    public Vector2 moveDirection;
    [SerializeField] public PlayerInputActions playerControls;
    public InputAction move;

    private void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    void Start()
    {
        facingRight = true;
    }

    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
        float horizontalMove = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (!facingRight && moveDirection.x > 0)
        {
            Flip();
        }
        else if (facingRight && moveDirection.x < 0)
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
}
