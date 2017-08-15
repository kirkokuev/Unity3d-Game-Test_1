using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyController : MonoBehaviour
    {
        public WanderingAI w_ai;
        public GameObject player;
        public GameObject psp;
        public GameObject projectile;
        public int life = 3;
        
        // Use this for initialization
        void Start()
        {
            w_ai = gameObject.GetComponent<WanderingAI>();
            player = GameObject.Find("Player");
        }

        // Update is called once per frame
        void Update()
        {
            if (life == 0)
            {
                Debug.Log("I am dead");
                Destroy(gameObject);
            }
        }

        public void AttackPlayer()
        {
                GameObject bullet = Instantiate(projectile, psp.transform.position, gameObject.transform.rotation) as GameObject;
            bullet.tag = "Projectile";
                Physics.IgnoreCollision(bullet.GetComponent<Collider>(), this.GetComponent<Collider>());
                bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 500);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                w_ai.player = player;
                w_ai.mode = "attack";
                Debug.Log("I see you! " + w_ai.enabled);
                InvokeRepeating("AttackPlayer", 3f, 1f);
            } 
        }
        public void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                CancelInvoke();
                w_ai.mode = "wandering";
                Debug.Log("I lost you! " + w_ai.enabled);
            }
        }
    }
}