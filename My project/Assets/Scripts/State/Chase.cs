using UnityEngine;

public class Chase : State
{
    public float speed;
    private Rigidbody2D myrigidbody;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x - transform.position.x > 0)
        {
            transform.localScale = new Vector3(-6, 6, 1);
            myrigidbody.linearVelocity = new Vector2(speed, 0);
        }
        else if (player.transform.position.x - transform.position.x < 0)
        {
            transform.localScale = new Vector3(6, 6, 1);
            myrigidbody.linearVelocity = new Vector2(-speed, 0);
        }
    }   
}
