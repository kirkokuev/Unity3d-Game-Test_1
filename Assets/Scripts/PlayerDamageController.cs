using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        player = gameObject.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("Player Hit");
            player.GetComponent<PlayerController>().life--;
        }
    }

}
