using UnityEngine;

public class Dying : State
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRenderer.color = new Color(1, 0.5f, 0.6f, 1);
    }
}
