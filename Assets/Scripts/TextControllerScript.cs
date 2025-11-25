using TMPro;
using UnityEngine;

public class TextControllerScript : MonoBehaviour
{
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMethod();
    }

    public void TextMethod()
    {
        text.text = "Health: " + LevelManager.instance.playerhp;
    }
}
