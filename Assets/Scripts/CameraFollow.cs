using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField]
    Camera Camera;

    
    // Use this for initialization
	void Start () {
        var CameraPos = new Vector3(0, 2.8f, -7);

        Camera.transform.position = transform.position + CameraPos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
