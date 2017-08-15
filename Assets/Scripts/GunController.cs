using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    public GameObject projectile;
    public GameObject player;
    public GameObject psp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject bullet = Instantiate(projectile, psp.transform.position, player.transform.rotation) as GameObject;
            Physics.IgnoreCollision(bullet.GetComponent<Collider>(), this.GetComponent<Collider>());
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 500);
        }

    }
}
