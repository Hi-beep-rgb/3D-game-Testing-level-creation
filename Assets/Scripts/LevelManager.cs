using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    //instance refers to the script itself
    public static LevelManager instance;
    private int highScore;
    public int playerhp;

    // Awake loads before the start method
    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("do not destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }
    }


    //these methods are globally accessible
    public void SetHighScore(int score)
    {
        highScore = score;
    }
    public int GetHighScore()
    {
        return highScore;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerhp = 100;

        if (PlayerPrefs.HasKey("ScoreValue"))
        {
            highScore = PlayerPrefs.GetInt("ScoreValue");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
