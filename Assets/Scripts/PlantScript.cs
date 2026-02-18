using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlantScript : MonoBehaviour
{
    

    //get the sprite renderer, the plot it belongs to, the plot script of that plot, and the sprites needed
    public SpriteRenderer sr;
    public GameObject myPlot;
    public PlotScript plotScript;
    public List<Sprite> stage;

    

    //current lifespan and maximum lifespan used for reflecting the plant's growth
    public float currentLifespan;
    public float maxLifespan;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the sprite renderer so we can change the sprite
        sr = GetComponent<SpriteRenderer>();
        //set a random lifespan for some variance
        maxLifespan = Random.Range(15, 30);
        //set the sprite to the first stage, a little sprout
        sr.sprite = stage[0];
    }

    // Update is called once per frame
    void Update()
    {
        

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
