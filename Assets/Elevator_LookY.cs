using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_LookY : MonoBehaviour {

    float sensitivity = 1f;

	
	// Update is called once per frame
	void Update () {
        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * sensitivity;
        transform.localEulerAngles = newRotation;


    }
}
