using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_LookX : MonoBehaviour {

    float _sensitivity = 1f;

	// Update is called once per frame
	void Update () {

        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x += _mouseY * _sensitivity * (-1);
        transform.localEulerAngles = newRotation;

	}
}
