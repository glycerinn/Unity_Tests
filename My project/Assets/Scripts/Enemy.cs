using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public float health { get; set; }
    public float Enemyhealth;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        health = Enemyhealth;
    }

    public void takeDamage(float damage)
    {
        health -= damage;
    }

    // // Update is called once per frame
    void Update()
    {
        if (health <= 0) Destroy(gameObject);
    }

}
