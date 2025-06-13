using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float bulletDirection;
    public float gracetime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gracetime -= Time.deltaTime;
        if (bulletDirection < 0)
        {
            MoveBulletLeft();
        }

        if (bulletDirection > 0)
        {
            MoveBulletRight();
        }
        if (gracetime < 0)
        {
            Destroy(gameObject);
        }
    }

    private void MoveBulletLeft()
    {
        myrigidbody.AddForce(Vector2.left * 5, ForceMode2D.Impulse);
    }

    private void MoveBulletRight()
    {
        myrigidbody.AddForce(Vector2.right * 5, ForceMode2D.Impulse);
    }
}
