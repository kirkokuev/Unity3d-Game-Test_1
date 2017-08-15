using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2f;
    public float spacing = 1.0f;
    private Vector3 pos;

    private Vector3 mouse_pos;
    private Vector3 object_pos;
    public Transform target;
    private float angle;


    // Use this for initialization
    void Start () {
        pos = transform.position;
 	}
	
	// Update is called once per frame
	void Update () {

        //  Movement control

        /*        if (Input.GetKey(KeyCode.A))
                    pos.x -= spacing;
                if (Input.GetKey(KeyCode.W))
                    pos.z += spacing;

                if (Input.GetKey(KeyCode.S))
                    pos.z -= spacing;

                if (Input.GetKey(KeyCode.D))
                    pos.x += spacing;

                transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        */

        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * Time.deltaTime * speed);
        // Rotation control

        /*        mouse_pos = Input.mousePosition;
                mouse_pos.z = 0; //The distance between the camera and object
                object_pos = Camera.main.WorldToScreenPoint(target.position);
                mouse_pos.x = mouse_pos.x - object_pos.x;
                mouse_pos.y = mouse_pos.y - object_pos.y;
                angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
                */
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 50);

    }

}
