using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlotScript : MonoBehaviour
{
    public int moisture;
    public bool moist;
    public float drenchingValue;
    public Slider drenchSlider;

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

        if(moisture > 500)
        {
            moisture = 1500;
        }


        if(drenchingValue > 0)
        {
            drenchingValue = drenchingValue - 1;
            if (drenchingValue > 50)
            {
                moisture = moisture + 2;
            }
        }

        drenchSlider.value = drenchingValue;
    }

    public void Drench(float scale)
    {
        drenchingValue = scale;
    }
}
