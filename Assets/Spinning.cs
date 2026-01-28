using UnityEngine;

public class Spinning : MonoBehaviour
{
    public bool isSpinning = true;
    public float speed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(0f, 0f, speed*Time.deltaTime);
        }
    }

    public void StartSpin()
    {
        isSpinning = true;
    }

    public void StopSpin()
    {
        isSpinning = false;
    }
}
