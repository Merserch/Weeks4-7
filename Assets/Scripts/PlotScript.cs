using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlotScript : MonoBehaviour
{
    //moisture for value, moist for plant reference
    public float moisture;
    public bool moist;
    //min and max values for clamping
    public float maxMoisture = 15f;
    public float minMoisture = -5f;
    //watering system components, drenching value for slider value and slider itself in the scene canvas
    public float drenchingValue;
    public Slider drenchSlider;
    //the plant object associated with this plot and it's script
    public GameObject myPlant;
    public PlantScript plantScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set to maximum moisture
        moisture = maxMoisture;
        //get the plant object
        plantScript = myPlant.GetComponent<PlantScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //while the moisture is more than the minimum, it's considered "moist"
        
        if(moisture > minMoisture)
        {
            moist = true;
        } else
        {
            moist = false;
        }

        //while being drunk from, the soil loses moisture
        if(plantScript.drinking == true)
        {
            moisture -= 1f * Time.deltaTime;
        }

        //this is the maximum saturation for the soil, any overflow is discarded
        if(moisture > maxMoisture)
        {
            moisture = maxMoisture;
        }

        //slider decay
        if(drenchingValue > 0)
        {
            //reduce the slider value
            drenchingValue -= 3f * Time.deltaTime;

            //increase moisture if above a certain value
            if (drenchingValue > 1)
            {
                moisture += 2f * Time.deltaTime;
            }

            //setting the slider to show the value of the drench after reducing the drench amount
            drenchSlider.value = drenchingValue;
        }

        
    }

    //function called when the slider moves
    public void Drench(float scale)
    {
        //this function will let the script know what the slider says
        drenchingValue = scale;
    }
}
