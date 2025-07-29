using UnityEngine;
using UnityEngine.Rendering;

public class CheckDistance : Condition
{
    public float maxdistanceTrigger;
    public float mindistanceTrigger;
    public Transform targetObject;
    private float distance;

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = targetObject.position;
        distance = Vector3.Distance(currentPosition, targetPosition);
    }

    public override bool CheckCondition()
    {
        if (distance <= maxdistanceTrigger && distance >= mindistanceTrigger)
        {
            return true;
        }
        return false;
    }
}           