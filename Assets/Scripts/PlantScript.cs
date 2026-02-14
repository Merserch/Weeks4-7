using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public SpriteRenderer sr;
    public int currentLifespan = 0;
    public int maxLifespan = 1500;
    public bool drinking = true;
    public GameObject myPlot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        //myPlot = GetComponent<PlotScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(myPlot.moisture > 0)
        // {
        //     currentLifespan++;
        // }


    }
}
