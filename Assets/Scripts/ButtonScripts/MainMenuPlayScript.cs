using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlayScript : MonoBehaviour
{
    public TMP_Text buttonText;


    public void EnterLevelSellection()
    {
        buttonText.text = "clicked";


        if (buttonText.text == "clicked")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            SceneManager.LoadSceneAsync(1);
            print("Frontend scene has been loaded.");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}