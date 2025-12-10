using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CanvasScript : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    const string MIXER_MUSIC = "MusicVolume";
    const string MIXER_SFX = "SFXVolume";

    private void Awake()
    {
    }

    public void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    public void SetSFXVolume(float value)
    {
    }

    public void MusicSliderChanged( float value )
    {
        print("value is " + value);
    }

    public void SfxSliderChanged(float value)
    {
        print("sfx value is " + value);
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);

    }



}
