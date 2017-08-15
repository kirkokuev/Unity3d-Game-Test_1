using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageController : MonoBehaviour {

    public GameObject enemy;
	// Use this for initialization
	void Start () {
        enemy = gameObject.transform.parent.gameObject;
        gameObject.tag = "Enemy";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("Hit");
            enemy.GetComponent<Enemy.EnemyController>().life--;
        }
    }

}
