using UnityEngine;

public class Roam : State
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D myrigidbody;
    private Animator animator;
    private Transform currentPoint;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentPoint = pointA.transform;
        animator.SetBool("Roam", true);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 point = currentPoint.position - transform.position;
        if (currentPoint.transform == pointB.transform)
        {
            myrigidbody.linearVelocity = new Vector2(speed, 0);
        }
        else
        {
            myrigidbody.linearVelocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            transform.localScale = new Vector3(-6, 6, 1);
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            transform.localScale = new Vector3(6, 6, 1);
            currentPoint = pointB.transform;
        }
    }

    // public void Flip()
    // {
    //     Vector3 localScale = transform.localScale;
    //     localScale.x *= -1f;
    //     transform.localScale = localScale;
    // }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 2.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 2.5f);
    } 
}
