using UnityEngine;
using System.Collections;
namespace Enemy
{
    public class WanderingAI : MonoBehaviour
    {

        public string mode = "wandering";
        public GameObject player;
        public float wanderRadius;
        public float wanderTimer;

        private Transform target;
        private UnityEngine.AI.NavMeshAgent agent;
        private float timer;

        // Use this for initialization
        void OnEnable()
        {
            mode = "wandering";
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            timer = wanderTimer;
        }

        // Update is called once per frame
        void Update()
        {
            if (mode == "wandering")
            {
                timer += Time.deltaTime;

                if (timer >= wanderTimer)
                {
                    Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                    agent.SetDestination(newPos);
                    timer = 0;
                }

            }
            else if (mode == "attack")
            {
                timer += Time.deltaTime;
                if (timer >= wanderTimer)
                {
                    Vector3 shooting_position = new Vector3(player.transform.position.x + Random.Range(1f,5f), player.transform.position.y, player.transform.position.z + Random.Range(1f,5f));
                    agent.destination = shooting_position;
                    gameObject.transform.LookAt(player.transform);
                    timer = 0;
                }
                    //                Debug.Log("Path found "+agent.SetDestination(player.transform.position));

                
            }
        }

        public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
        {
            Vector3 randDirection = Random.insideUnitSphere * dist;

            randDirection += origin;

            UnityEngine.AI.NavMeshHit navHit;

            UnityEngine.AI.NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

            return navHit.position;
        }
    }
}