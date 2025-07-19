using UnityEngine;

public class Entity : MonoBehaviour, IDamageable
{
    public float health { get; set; }
    public void takeDamage(float damage)
    {
        health -= damage;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}