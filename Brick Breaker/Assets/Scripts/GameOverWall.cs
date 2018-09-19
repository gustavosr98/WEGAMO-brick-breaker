using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWall : MonoBehaviour {

   [SerializeField] GameStatus gameStatus;

    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameStatus.getLives() <= 1)
        {
            SceneLoader sceneLoader = new SceneLoader();
            sceneLoader.LoadGameOver();
        }
        else
        {
            gameStatus.LostOneLive();
            SceneLoader sceneLoader = new SceneLoader();
            sceneLoader.LoadSameLevel();
        }
    }
}
