using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);       
    }

    public void LoadSameLevel()
    {
        Ball ball = FindObjectOfType<Ball>();
        ball.StickToPlayer();
    }
    
    public int LevelIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
