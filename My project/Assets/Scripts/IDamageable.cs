using Unity.VisualScripting;
using UnityEngine;

public interface IDamageable
{
    public float health { get; set; }
    public void takeDamage(float damage);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
