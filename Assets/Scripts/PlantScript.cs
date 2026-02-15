using UnityEngine;
using System.Collections.Generic;

public class PlantScript : MonoBehaviour
{
    //current lifespan and maximum lifespan used for reflecting the plant's growth
    public float currentLifespan = 0f;
    public float maxLifespan = 30f;
    //drinking used by plot script
    public bool drinking = true;

    //get the sprite renderer, the plot it belongs to, the plot script of that plot, and the sprites needed
    public SpriteRenderer sr;
    public GameObject myPlot;
    public PlotScript plotScript;
    public List<Sprite> stage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the sprite renderer so we can change the sprite
        sr = GetComponent<SpriteRenderer>();
        //get the plot script so we can see if the soil is wet
        plotScript = myPlot.GetComponent<PlotScript>();
        //set the sprite to the first stage, a little sprout
        sr.sprite = stage[0];
    }

    // Update is called once per frame
    void Update()
    {
        //check the moisture of the soil
        if(plotScript.moisture > 0)
        {
            //if it's wet, it may drink and grow
            currentLifespan += 1f * Time.deltaTime;
            drinking = true;
        }

        //if moisture is low, drinking will not change but the lifespan will not increase

        if(plotScript.moist == false)
        {
            //if the minimum moisture level is met, the plant will stop drinking
            drinking = false;
        }

        //set the sprite once reaching a certain age
        if(currentLifespan >= maxLifespan * 1 / 3)
        {
            //if even older, set the older sprite stage
            if(currentLifespan >= maxLifespan * 2 / 3)
            {
                sr.sprite = stage[2];
            }
            //otherwise set the second stage sprite
            else
            {
                sr.sprite = stage[1];
            }
        }

    }
}
