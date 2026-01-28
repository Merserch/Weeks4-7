using UnityEngine;
using UnityEngine.InputSystem;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ChangeColour();
        }
    }

    public void ChangeColour()
    {
        sr.color = Random.ColorHSV();
    }

    public void ChangeSize(float size)
    {
        transform.localScale = Vector3.one * size;
    }
}
