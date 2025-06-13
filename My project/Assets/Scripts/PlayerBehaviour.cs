using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerBehaviour : Player
{
    public Rigidbody2D myrigidbody;
    public float direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") < 0)
        {
            MoveLeft();
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            MoveRight();
        }

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
