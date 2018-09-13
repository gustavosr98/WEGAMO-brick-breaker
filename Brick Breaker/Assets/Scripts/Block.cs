using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    Level level; 

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountOneBlock();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); //funciona como un Destroy(this)
        level.DiscountOneBlock();
        level.CheckForFinishedLevel();
    }
}
