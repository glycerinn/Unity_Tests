using UnityEngine;

public class Ground : MonoBehaviour, IDamageable
{
    public float health { get; set; }
    public void takeDamage(float damage) {
        health -= damage;
    }
    

}
