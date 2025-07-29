using Unity.VisualScripting;
using UnityEngine;

public class Injured : State
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRenderer.color = new Color(0.75f, 0.75f, 0.75f, 1);
    }
}
