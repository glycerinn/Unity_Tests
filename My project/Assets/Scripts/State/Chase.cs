using UnityEngine;

public class Chase : State
{
    public float speed;
    private Rigidbody2D myrigidbody;
    public GameObject player;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
        animator.SetBool("Roam", true);
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
