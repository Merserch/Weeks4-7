using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image duckyImage;    //the ducky image on the canvas
    public int howManyClicks = 0;   //A counter for the clicking
    public TextMeshProUGUI score;
    public Slider slider;
    public TextMeshProUGUI sliderDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score.text =  howManyClicks.ToString();

        slider.wholeNumbers = true;
        slider.minValue = 1;
        slider.maxValue = 5;
        slider.value = 3;
    }

    // Update is called once per frame
    void Update()
    {
        sliderDisplay.text = slider.value.ToString();

        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            ChangeColour();
        }
    }

    public void ChangeColour()
    {
        
        sr.color = Random.ColorHSV();
        duckyImage.color = sr.color;
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void AddToTheNumber()
    {
        howManyClicks++;
        score.text =  howManyClicks.ToString();
    }
}
