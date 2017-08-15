using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.tag = "Projectile";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Sensor")
        {
            Destroy(gameObject);
        } 
    }
}
