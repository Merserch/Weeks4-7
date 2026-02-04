using UnityEngine;
using UnityEngine.UI;

public class TimerModule : MonoBehaviour
{
    public float TimerValue = 0f;
    public float MaxTimerValue = 10f;
    public Slider timerVisuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        timerVisuals.maxValue = MaxTimerValue;


    }

    // Update is called once per frame
    void Update()
    {
        TimerValue += Time.deltaTime;
        timerVisuals.value = TimerValue;

        if (TimerValue >= MaxTimerValue)
        {
            TimerValue = 0f;
            
        }

    }
}
