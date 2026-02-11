using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

public class barrelScript : MonoBehaviour
{

    public GameObject swordPrefab; // assign this in the inspector with the sword prefab
    public int numberOfSwords = 0; // number of swords to spawn
    public int maxNumberOfSwords = 5;
    public GameObject spawnedSword;

    public List<GameObject> swords;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // spawn 5 swords
        
        

        for (int i = 0; i < maxNumberOfSwords; i++)
        {
            //instantiate the sword prefab at the position of the barrel with no rotation
            spawnedSword = Instantiate(swordPrefab, transform.position, Quaternion.identity);
            // increment the number of swords
            numberOfSwords++;
            // add the spawned sword to the list of swords
            swords.Add(spawnedSword);
         
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
