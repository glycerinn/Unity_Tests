using System.Collections;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public float health { get; set; }
    public float Enemyhealth;
    public Color newColor;
    public SpriteRenderer rend;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        health = Enemyhealth;
        rend = GetComponent<SpriteRenderer>();
    }

    public void takeDamage(float damage)
    {
        health -= damage;
    }

    // // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            animator.SetBool("Dead", true);
            Destroy(gameObject, 2f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            StartCoroutine(flashRed());
        }
    }

    public IEnumerator flashRed()
    {
        rend.color = newColor;
        yield return new WaitForSeconds(0.5f);
        rend.color = Color.white;
    }

    // public IEnumerator deathAnim()
    // {

    // }

}
