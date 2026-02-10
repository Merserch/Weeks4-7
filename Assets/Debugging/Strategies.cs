using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        //set the number of times the loop should happen
        for (int i = 0; i < 20; i++)
        {
            float x = i;
            float y = i/10f;
            float z = 0;
            Debug.Log("y = " + y);
            //spawn the individual items at an x position thats increasing by 1 and y by 0.1.
            Instantiate(prefab, new Vector3 (x, y, z), Quaternion.identity);
        }
    }

}
