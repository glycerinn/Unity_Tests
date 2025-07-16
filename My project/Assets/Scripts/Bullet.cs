using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float gracetime;
    public float damage;
    public float speed;
    public bool bulletDirection;
    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        myrigidbody = GetComponent<Rigidbody2D>();
        bulletDirection = player.GetComponent<PlayerBehaviour>().facingRight;
    }

    // Update is called once per frame
    void Update()
    {
        gracetime -= Time.deltaTime;
        if (bulletDirection == false )
        {
            myrigidbody.linearVelocity = Vector2.left * speed;
        }
        else if (bulletDirection == true )
        {
            myrigidbody.linearVelocity = Vector2.right * speed;
        }

        // else
        // {
        //     myrigidbody.linearVelocity = new Vector2(bulletDirection * speed, transform.position.y) * Time.deltaTime;
        // }

        if (gracetime < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Enemy") && !other.CompareTag("Ground")){ 
            return;
        }
        other.GetComponent<IDamageable>().takeDamage(damage);
        Destroy(gameObject, 0.01f);
        
    }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("Enemy"))
    //     {
    //         other.GetComponent<IDamageable>().takeDamage(damage);
    //         Destroy(gameObject);
    //     }
    // }  
}
