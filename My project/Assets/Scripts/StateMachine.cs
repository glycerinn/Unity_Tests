using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public List<State> states;
    public List<Condition> conditions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < conditions.Count; i++)
        {
            if (conditions[i].CheckCondition())
            {
                states[i].enabled = true;
            }
            else
            {
                states[i].enabled = false;
            }
        }
    }
}
