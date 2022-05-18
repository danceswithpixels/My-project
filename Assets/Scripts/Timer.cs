using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteLevel = 10f;
    public bool isCompletingLevel;
    
    public float fillFraction;
    float timerValue;

    void Start() 
    {
        timerValue = timeToCompleteLevel;
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer() 
    {
        timerValue -= Time.deltaTime;

        if (isCompletingLevel)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteLevel;
            }
            else 
            {
                isCompletingLevel = false;
            }
        }
    }
}
