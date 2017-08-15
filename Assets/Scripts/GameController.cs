using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject box;
    public GameObject enemy;
    public int enemy_count;
    public int box_count;

	// Use this for initialization
	void Start () {
               GenerateBoxes();
        GenerateEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateEnemies()
    {
        for (int i = 0; i <= enemy_count; i++)
        {
            GameObject enemy_clone = Instantiate(enemy, new Vector3(Random.Range(0f, 100f), 0.5f, Random.Range(0f, 100f)), transform.rotation) as GameObject;

        }
    }
        public void GenerateBoxes()
    {
        for (int i = 0; i <= box_count; i++)
        {
            GameObject box_clone = Instantiate(box, new Vector3(Random.Range(0f, 100f), Random.Range(0f, 100f), Random.Range(0f, 100f)), transform.rotation) as GameObject;
            box_clone.transform.localScale += new Vector3(Random.Range(1f, 5f), Random.Range(1f, 5f), Random.Range(1f, 5f));
        }

    }
}
