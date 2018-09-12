﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //Parametros de seteo
    [SerializeField] Player player;

    //Atributos
    Vector2 DistanciaEntreBarraPelota;
    bool hasStarted;
    [SerializeField] float xPush = 10f;
    [SerializeField] float yPush = 10f;


    // Use this for initialization
    void Start () {
        hasStarted = false;
        DistanciaEntreBarraPelota = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted) {
            LockBallToPlayer();
            LaunchOnMouseClick();
        }
	}

    void LockBallToPlayer() {
        transform.position = (Vector2) player.transform.position + DistanciaEntreBarraPelota;
    }

    void LaunchOnMouseClick()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }
}
