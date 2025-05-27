using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myrigidbody.linearVelocity = Vector2.up * 10;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            myrigidbody.linearVelocity = Vector2.left * 10;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            myrigidbody.linearVelocity = Vector2.right * 10;
        }
    }
}
