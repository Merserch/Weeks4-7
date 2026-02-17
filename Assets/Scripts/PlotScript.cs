using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections.Generic;

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
    //button for spawning plant
    public GameObject spawnPlant;
    //button for despawning plant
    public GameObject harvestPlant;
    //the plant object associated with this plot and it's script
    public GameObject plantPrefab;
    public GameObject myPlant;
    public PlantScript plantScript;
    public GameObject needWater;
    //the plant spawn point
    public Vector2 spawnPoint;
    //drinking used by plot script
    public bool drinking;
    //get the timer component in the world UI
    public GameObject timerHand;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set to maximum moisture
        moisture = maxMoisture;
        spawnPoint = new Vector2(transform.position.x, transform.position.y + 2);
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

        //things to do while the plant is alive
        if (plantScript != null)
        {
            
            //while being drunk from, the soil loses moisture
            if(drinking == true)
            {
                moisture -= 1f * Time.deltaTime;
                needWater.SetActive(false);
            }
            else
            {
                needWater.SetActive(true);
            }

            //check the moisture of the soil
            if(moisture > 0 && plantScript.currentLifespan < plantScript.maxLifespan)
            {
                //if it's wet, it may drink and grow
                plantScript.currentLifespan += 1f * Time.deltaTime;
                drinking = true;

                //set the timer hand to reflect the percentage of time left until fully grown
                Vector3 handRotation = timerHand.transform.eulerAngles;
                handRotation.z -= 360 / plantScript.maxLifespan * Time.deltaTime;
                timerHand.transform.eulerAngles = handRotation;
            }


            //if moisture is low, drinking will not change but the lifespan will not increase

            if(moist == false)
            {
                //if the minimum moisture level is met, the plant will stop drinking
                drinking = false;
            }

            if(plantScript.currentLifespan >= plantScript.maxLifespan)
            {
                harvestPlant.SetActive(true);
            }
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

    public void NewPlant()
    {
        
        myPlant = Instantiate(plantPrefab, spawnPoint, Quaternion.identity);

        //get the plant object
        plantScript = myPlant.GetComponent<PlantScript>();
        spawnPlant.SetActive(false);
        //current lifespan and maximum lifespan used for reflecting the plant's growth
        plantScript.currentLifespan = 0f;
        plantScript.maxLifespan = 10f;
        
    }

    public void HarvestPlant()
    {
        Destroy(myPlant);
        harvestPlant.SetActive(false);
        spawnPlant.SetActive(true);
    }
}
