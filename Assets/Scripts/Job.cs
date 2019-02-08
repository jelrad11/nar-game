using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour {

	[SerializeField]
	public int JobID;
	
	private TaskManager _TM;

	[SerializeField] public Task _T;
	
	[SerializeField] public ParticleSystem Ps;

	[SerializeField] FogOfWar _fogOfWarScript;


	
	

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
		
		if(other.gameObject.tag == "Player" && _fogOfWarScript.fogOfWar == true)
		{
			_fogOfWarScript.fade();  
		}
		
		_TM.taskWorkingID  = JobID;	
		ParticleSystem _Ps = Ps.GetComponent<ParticleSystem>(); 
		_Ps.Play();


			if(JobID == _TM.givenTask)
			{
				Debug.Log("Player is working on his task");
		
				_TM.taskWorking = true;
			}
			


	}

	void OnTriggerStay (Collider other)
	{
		if(_TM.taskWorking == true)
		{
			StartCoroutine("corWorking");



		}
	}

	IEnumerator corWorking ()
	{

		yield return new WaitForSeconds (5f);

		_TM.taskWorking = false;
		_TM.taskAccomplished = true;
		Debug.Log("Job at " + _T.TaskList[JobID] + " is finished!" );
		_TM.tasksFinished++;
		StopCoroutine("corWorking");
	}
		void OnTriggerExit (Collider other)
	{
		StopCoroutine("corWorking");
		Debug.Log("- " + other.name + " Odešel ze zóny " + _T.TaskList[JobID]);
		_TM.taskWorking = false;
		_TM.taskWorkingID = 0;
		
	}
}


