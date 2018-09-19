using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI livesText;

    [SerializeField] int score = 0;
    [SerializeField] int lives = 3;

    public void Start()
    {
        if (lives >= 0)
            DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void UpdateLives()
    {
        livesText.text = lives.ToString();
    }

    public int getScore()
    {
        return score;
    }
    
    public void addScore(int points)
    {
        score += points;
        UpdateScore();
    }

    public int getLives()
    {
        return lives;
    }
    
    public void LostOneLive()
    {
        lives--;
        UpdateLives();
    }

    public void ResetScoreLives()
    {
        score = 0;
        lives = 3;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
    
 
	
}
