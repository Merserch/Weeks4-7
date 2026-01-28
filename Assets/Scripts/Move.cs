using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 20f;
    public AnimationCurve speedCurve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position += transform.up * Time.deltaTime * speedCurve.Evaluate(speedCurve);
    }
}
