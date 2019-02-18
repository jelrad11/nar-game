using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour {

	[SerializeField]
	public int JobID;
	
	[SerializeField]
	public ParticleSystem Ps;
	[System.NonSerialized] public string[] TaskList = {
					"Out",					//0
					"Players Cube", 		//1
					"Colleagues Cube",		//2
					"Boss",					//3
					"Meeting", 				//4
					"Common room",			//5
					"Lockers",				//6
					"Storage",				//7

					};
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

