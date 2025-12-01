using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;
    int recover;

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
}
