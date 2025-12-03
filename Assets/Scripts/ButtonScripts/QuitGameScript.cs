using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGameScript : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;

    public void ButtonMethod()
    {
        buttonText.text = "Clicked";

        if (buttonText.text == "Clicked")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
            print("Returning to the main menu");
            SceneManager.LoadScene("Frontend");
        }
    }

    public void QuitToMain()
    {
        //play the sound effect
        FindFirstObjectByType<AudioManager>().Play("Button Click");
        SceneManager.LoadSceneAsync(0);
        print("Main Menu scene has been loaded.");
    }
}
