using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    private Rigidbody2D lootrb;
    public float dropForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lootrb = GetComponent<Rigidbody2D>();
        lootrb.AddForce(Vector2.up * dropForce, ForceMode2D.Impulse);
    }
}
