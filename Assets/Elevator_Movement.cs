using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_Movement : MonoBehaviour {

    float speed = 3.5f;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
    Movement();
    HideCursor();
    }
            void Movement()
        {
        Vector3 newPos = transform.position;

        float _horizontal = Input.GetAxis("Horizontal")* speed;
        float _vertical = Input.GetAxis("Vertical") * speed;
        //float _upDown = Input.GetAxis("UpDown") * speed;


        transform.Translate(new Vector3 (_horizontal,0,0) * Time.deltaTime, Space.World);
        transform.Translate(new Vector3 (0,0,_vertical) * Time.deltaTime, Space.World);
        //transform.Translate(0,_upDown,0);
        
        }

        void HideCursor()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Debug.Log("Vítej zpět, kurzore!");
            }            


        }
}
