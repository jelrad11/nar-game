using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour {

	[SerializeField]
	public int JobID;
	
	private TaskManager _TM;

	[SerializeField] public Task _T;
	
	[SerializeField] public ParticleSystem Ps;

	
	

	void Awake()
	{
		_TM = GameObject.FindGameObjectWithTag("Task Manager").GetComponent<TaskManager>();
	}

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



	void OnTriggerEnter (Collider other)
	{
		Debug.Log("+ " + other.name + " Vstoupil do zóny " + _T.TaskList[JobID]);	
		ParticleSystem _Ps = Ps.GetComponent<ParticleSystem>(); 
		_Ps.Play();

		_TM.taskWorking = true;
	}

		void OnTriggerExit (Collider other)
	{
		Debug.Log("- " + other.name + " Odešel ze zóny " + _T.TaskList[JobID]);
		_TM.taskWorking = false;

	}
}

