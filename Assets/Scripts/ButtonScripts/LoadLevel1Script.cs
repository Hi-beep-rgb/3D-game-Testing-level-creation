using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1Script : MonoBehaviour
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
            print("Level 1 is loading");
            SceneManager.LoadScene("Level 1");
        }
    }
}
