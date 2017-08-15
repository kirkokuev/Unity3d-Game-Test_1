using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int life = 3;

	// Use this for initialization
	void Start () {
        gameObject.tag = "Player";
	}
	
	// Update is called once per frame
	void Update () {
	    if (life == 0)
        {
            Debug.Log("Player dead");
            Destroy(gameObject);
        }	
	}
}
