using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddPointButtonScrpt : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;

    public void AddButtonMethod()
    {
        buttonText.text = "+";

        if (buttonText.text == "+")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            LevelManager.instance.AddPoints();
        }
    }
}
