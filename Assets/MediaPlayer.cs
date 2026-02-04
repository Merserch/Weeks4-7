using UnityEngine;
using UnityEngine.UI;

public class MediaPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float currentTime;
    public Slider timeSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = audioSource.time;
        timeSlider.value = currentTime;
    }

    public void PlayMedia()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }

    }

    public void PauseMedia()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }
}
