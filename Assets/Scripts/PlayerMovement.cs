using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private CharacterController _controller;
    [SerializeField]
    private float _speed = 3.5f;
    public int enemiesGone = 0;
	// Use this for initialization


	void Start ()
    {
        _controller = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.Escape))
        {            
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Welcome back cursor...");
            



        }

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),0 ,Input.GetAxis("Vertical"));
        Vector3 velocity = direction * _speed;

        velocity = transform.transform.TransformDirection(velocity);
        _controller.Move(velocity * Time.deltaTime);

    }
}
