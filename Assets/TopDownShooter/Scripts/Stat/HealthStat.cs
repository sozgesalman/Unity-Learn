using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    private float Health = 100;
    public void Hit(float damage)
    {
        if(Health <= 0)
        {
            Debug.Log("Health zero.");
        }
        else
        {
            Debug.Log("Current Health Account: " +Health);
        }
    }
}