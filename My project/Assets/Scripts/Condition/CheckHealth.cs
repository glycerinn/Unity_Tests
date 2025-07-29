using UnityEngine;

public class CheckHealth : Condition
{
    public float healthTrigger;
    private Enemy enemyScript;
    public GameObject enemy;

    private void Start()
    {
        enemyScript = GetComponent<Enemy>();
    }
    public override bool CheckCondition()
    {
        if (enemyScript.health <= healthTrigger)
        {
            return true;
        }
        return false;
    }
}
