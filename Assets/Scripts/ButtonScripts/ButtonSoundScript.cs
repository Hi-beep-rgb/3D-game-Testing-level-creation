using TMPro;
using UnityEngine;

public class ButtonSoundScript : MonoBehaviour
{
    // public variable to reference the button text
    public TMP_Text buttonText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OptionsButtonMethod()
    {
        buttonText.text = "Options";

        if (buttonText.text == "Options")
        {
            //play the sound effect
            FindFirstObjectByType<AudioManager>().Play("Button Click");
        }
    }
}
