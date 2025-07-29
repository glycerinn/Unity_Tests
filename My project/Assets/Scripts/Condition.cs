using UnityEngine;

public class Condition : StateMachine
{
    public virtual bool CheckCondition()
    {
        return false;
    }
}
