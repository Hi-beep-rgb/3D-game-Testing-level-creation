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
            print("Returning to the main menu");
            SceneManager.LoadScene("Frontend");
        }
    }
}
