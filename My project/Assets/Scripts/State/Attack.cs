using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : State
{
    public float attackCooldown;
    public float damage;
    public float attackTimer;
    private Animator animator;
    public Transform player;
    public float enemyDistance;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        enemyDistance = Vector3.Distance(transform.position, player.position);
        attackTimer -= Time.deltaTime;
        if (attackTimer <= 0)
        {
            animator.SetBool("Roam", false);
            StartCoroutine(AttackRoutine());
            attackTimer = attackCooldown;
        }
        if (enemyDistance >= 6)
        {
            animator.SetBool("Roam", true);
        }
    }

    public IEnumerator AttackRoutine()
    {
        animator.SetBool("isAttack", true);
        yield return new WaitForSeconds(1f);
        animator.SetBool("isAttack", false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
        if (collision.gameObject.CompareTag("Player"))
        {
            damageable.takeDamage(damage);
        }
    }
}
