using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 16f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Move();	
	}

    //Por defecto los metodos son privados
    void Move()
    {
        Vector2 barPosition = new Vector2(Input.mousePosition.x / Screen.width * screenWidthInUnits, transform.position.y);
        transform.position = barPosition;
    }
}
