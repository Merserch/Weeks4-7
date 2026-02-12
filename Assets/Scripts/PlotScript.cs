using UnityEngine;

public class PlotScript : MonoBehaviour
{
    public int moisture;
    public bool moist;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moisture = 500;
        moist = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(moisture > -500)
        {
            moisture--;
            moist = true;
        } else 
        {
            moist = false;
        }

    }
}
