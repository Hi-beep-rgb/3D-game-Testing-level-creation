using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;
    public Slider sfxSlider;
    int recover;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sfxSlider.value = 1f;
    }

    public void ButtonMethod()
    {
        buttonText.text = "Clicked";
        recover = 100;

        if (buttonText.text == "Clicked")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            LevelManager.instance.playerhp = recover;
            print("Players hp has been reset");
        }
    }

    public void ChangeSFXVolume(float volume)
    {
        AudioManager.instance.sfxVol = volume;
    }
}
