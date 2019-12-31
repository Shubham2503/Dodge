using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    public Text HealthText;
    public Text HighScoreText;

    public int sc = 0,health = 0;

    void Start ()
    {
		
	}

    public void Update()
    {
        sc = PlayerPrefs.GetInt("NetScore");
        health = PlayerPrefs.GetInt("Health");
    }

    
	void FixedUpdate ()
    {
        
        scoreText.text = sc.ToString("0");
        HealthText.text = health.ToString("0");
       
        if (sc > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", sc);
        }
        HighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString("0");
    }
}
