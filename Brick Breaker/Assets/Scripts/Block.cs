using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    //config parameters
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] hitSprites;
    [SerializeField] GameObject DustEffect;

    //cached parameters
    Level level;
    GameStatus gameStatus;

    //state parameters
    int timesHit;
    

    private void Start()
    {
        if (tag == "Breackable")
        {
            gameStatus = FindObjectOfType<GameStatus>();
            level = FindObjectOfType<Level>();
            level.CountOneBlock();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TriggerDust();
        if (tag == "Breackable")
        {
            gameStatus.addScore(100);
            timesHit++;
            if (timesHit >= maxHits)
                DestroyBlock();
            else
                Break();
        }
    }

    void Break()
    {
        GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit - 1];
    } 

    void DestroyBlock()
    {
        Destroy(gameObject); //funciona como un Destroy(this)
        level.DiscountOneBlock();
        level.CheckForFinishedLevel();
    }

    void TriggerDust()
    {
        GameObject dust = Instantiate(DustEffect, new Vector3(transform.position.x, transform.position.y, -1) , transform.rotation);
        Destroy(dust, 1f); //para que no se acumulen en la escena al terminar de hacer el efecto
    }

}
