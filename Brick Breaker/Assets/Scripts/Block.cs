using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    //config parameters
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] hitSprites;
    
    //cached parameters
    Level level;

    //state parameters
    int timesHit;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountOneBlock();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
            DestroyBlock();
        else
            Break();
    }

    void Break()
    {
        GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit - 1];
    } 

    private void DestroyBlock()
    {
        Destroy(gameObject); //funciona como un Destroy(this)
        level.DiscountOneBlock();
        level.CheckForFinishedLevel();
    }
}
