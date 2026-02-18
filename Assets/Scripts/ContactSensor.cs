using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hazard.bounds.Contains(transform.position))
        {
            if(isInHazard)
            {
                //still within hazard

            }
            else
            {
                //jsut entered the hazard's bounds
                isInHazard = true;
                Debug.Log("Entered the hazard!");
                OnEnterSensor.Invoke();
                OnRandomNumber.Invoke(Random.Range(0f, 10f));
            }
            
        }
        else
        {
            if(isInHazard)
            {
                //just exited the hazard's bounds
                isInHazard = false;
                Debug.Log("Exited the hazard!");
                OnExitSensor.Invoke();
            }
            else
            {
                //still outside the hazard
            }
        }

        
    }

    public void ShowNumber(float number)
    {
        Debug.Log("The number is: " + number);
    }
}
