using UnityEngine;

public class Crate : MonoBehaviour, IDamageable
{
    public float crateHealth;
    public float health { get; set; }
    public Animator animator;
    public void takeDamage(float damage)
    {
        health -= damage;
    }

    void Start()
    {
        health = crateHealth;
    }

     void Update()
    {
        if (health < 60 && health > 0)
        {
            animator.SetBool("Hit Once", true);
        }
        if (health <= 0)
        {
            animator.SetBool("Death", true);
            Destroy(gameObject, 0.5f);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
