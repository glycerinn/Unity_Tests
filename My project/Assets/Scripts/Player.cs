using UnityEngine;

public class Player : Entity
{
    public float playerhealth;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = playerhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
