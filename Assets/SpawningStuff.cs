using UnityEngine;

public class SpawningStuff : MonoBehaviour
{
    public GameObject missilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMissile()
    {
        transform.localPosition = new Vector3(Random.Range(-8f, 8f), -5.2f, 0f);
        Instantiate(missilePrefab, transform.position, Quaternion.identity);
    }
}
