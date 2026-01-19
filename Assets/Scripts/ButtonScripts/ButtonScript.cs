using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    
    // public variable to reference the button text
    public TMP_Text buttonText;
    int recover;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void ButtonMethod()
    {
        buttonText.text = "RESET";
        recover = 100;

        if (buttonText.text == "RESET")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            LevelManager.instance.playerhp = recover;
            print("Players hp has been reset");
        }
    }
}
