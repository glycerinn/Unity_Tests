using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float bulletDirection;
    public float gracetime;
    public float damage;
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

    private void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<Enemy>();
        if (damageable != null)
        {
            damageable.takeDamage(damage);
            Destroy(gameObject);
        }
        
    }

    //     void Update()
    //     {
    //         transform.Translate(0.1f, 0, 0);
    //         gracetime -= Time.deltaTime;
    //         if (gracetime < 0)
    //         {
    //             Destroy(gameObject);
    //         }
    //     }

    //     public void SetDirection(float _direction)
    //     {
    //         bulletDirection = _direction;
    //         gameObject.SetActive(true);

    //         float localScaleX = transform.localScale.x;
    //         if (Mathf.Sign(localScaleX) != _direction)
    //         {
    //             localScaleX = -localScaleX;
    //         }

    //         transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    //    }
}
