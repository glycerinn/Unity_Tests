using System.Collections;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Entity
{
    public float Enemyhealth;
    // public Color newColor;
    public SpriteRenderer rend;
    public Animator animator;
    public Image healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        health = Enemyhealth;
        rend = GetComponent<SpriteRenderer>();
    }

    // // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health/Enemyhealth;
        if (health <= 50)
        {
            healthBar.color = Color.red;
        }
        if (health <= 0)
            {
                animator.SetBool("Dead", true);
                Destroy(gameObject, 1.5f);
            }
    }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("Bullet"))
    //     {
    //         StartCoroutine(flashRed());
    //     }
    // }

    // public IEnumerator flashRed()
    // {
    //     rend.color = newColor;
    //     yield return new WaitForSeconds(0.5f);
    //     rend.color = Color.white;
    // }

}
