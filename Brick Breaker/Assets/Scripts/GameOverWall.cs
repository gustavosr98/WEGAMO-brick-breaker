using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWall : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneLoader sceneLoader = new SceneLoader();
        sceneLoader.LoadGameOver();
    }
}
