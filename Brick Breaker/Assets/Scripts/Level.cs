using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int blocksCount = 0;
    Ball ball;

    public void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    public void CheckForFinishedLevel()
    {
        if ( (ball.isMoving() ) && (blocksCount <= 0))
        {
            SceneLoader sceneLoader = new SceneLoader();
            sceneLoader.LoadNextLevel();
        }
    }

    public void CountOneBlock()
    {
        blocksCount++;
    }

    public void DiscountOneBlock()
    {
        blocksCount--;
    }

       
}
