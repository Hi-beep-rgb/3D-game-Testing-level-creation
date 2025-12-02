using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerData : MonoBehaviour
{
    public int highScore;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("ScoreValue"))
        {
            highScore = PlayerPrefs.GetInt("ScoreValue");
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = highScore.ToString();
    }

    public void AddPoints()
    {
        highScore += 50;
    }

    public void RemovePoints()
    {
        highScore -= 50;
    }

    public void SavePoints()
    {
        PlayerPrefs.SetInt("ScoreValue", highScore);
    }

    public void LoadPoints()
    {
        highScore = PlayerPrefs.GetInt("ScoreValue");
    }
}
