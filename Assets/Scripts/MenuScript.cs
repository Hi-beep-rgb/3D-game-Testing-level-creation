using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    void Awake()
    {
        AudioManager.instance.musicVol = 1;
        AudioManager.instance.sfxVol = 1;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.Play("Background Music");
        musicSlider.value = 1f;
        sfxSlider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        AudioManager.instance.ChangeAudioSourceVolume("Button Click", AudioManager.instance.sfxVol);

        AudioManager.instance.ChangeAudioSourceVolume("Hit", AudioManager.instance.sfxVol);

        AudioManager.instance.ChangeAudioSourceVolume("Background Music", AudioManager.instance.musicVol);
    }
}
