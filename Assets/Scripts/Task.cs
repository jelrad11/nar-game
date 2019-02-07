using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour {

	[SerializeField]
	public int JobID;
	
	[SerializeField]
	public ParticleSystem Ps;
	[System.NonSerialized] public string[] TaskList = {
					"Out",
					"Players Cube", 
					"Colleagues Cube",
					"Boss",
					"Meeting", 
					"Canteen"};

	void Start()
	{
		var _Player = GameObject.FindGameObjectWithTag("Player");
		if(_Player != null)
		{
			Debug.Log("Player found");	
		}
		else
		{
			Debug.Log("Error: Player not Found");	
		}

	}
}

