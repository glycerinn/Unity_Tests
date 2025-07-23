using UnityEngine;

public class Crate : MonoBehaviour, IDamageable
{
    public float crateHealth;
    public float health { get; set; }
    public Animator animator;
    public GameObject[] loot;
    public bool dropLootOnce = false;
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
        else if (health <= 0)
        {
            if (!dropLootOnce)
            {
                dropLootOnce = true;
                ItemDrop();

            }
            animator.SetBool("Death", true);
            Destroy(gameObject, 0.5f);

        }
    }

    private void ItemDrop()
    {
        Instantiate(loot[0], transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
