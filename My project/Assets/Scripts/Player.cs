using UnityEngine;
using UnityEngine.UI;

public class Player : Entity, IDamageable
{
    public float playerhealth;
    public Animator animator;
    public Image healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = playerhealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / playerhealth;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
