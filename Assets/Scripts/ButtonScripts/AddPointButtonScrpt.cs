using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddPointButtonScrpt : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;
    int plusScore;

    public void AddButtonMethod()
    {
        buttonText.text = "+";
        plusScore = 50;

        if (buttonText.text == "+")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            LevelManager.instance.highScore += plusScore;
            print("50 points have been added to the score.");
        }
    }
}
