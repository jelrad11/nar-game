using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour {
	
	private RectTransform _reckTransform;
	
	public TMP_FontAsset _font;
	
	[SerializeField]
	private TextMeshProUGUI _Task;

	public bool taskNew;
	public bool taskAccomplished;
	public bool taskWorking;
	public int taskWorkingID;
	public int givenTask;
	public int tasksFinished;

	[System.NonSerialized] public bool taskLookingFor = true;



	//private Vector3 LerpTaskAnimationStart = new Vector3(0.8301842f, 0.8301842f, 0.8301842f);
	//private Vector3 LerpTaskAnimationEnd = new Vector3(0.950644f,0.950644f,0.950644f);
	//private float LerpTaskAnimationValue = 5f;
	//private float LerpTaskAnimationSmooth = 0;



	 [System.NonSerialized] public string[] jobs = {  //List of jobs, that pop up on sticky note (Must correspond to list in Task.cs)
		 				"Out",
		 				"Go to your office", 
	 					"Go to your colleagues office",
						"Go to the Boss",
						"Go to the meeting room",
						"Go for a lunch with your colleagues"};
	 
	// Use this for initialization
	void Start () {
		//Text
		_Task = GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>(); // Fetch or Add TMPRO Component
		_reckTransform = GetComponent<RectTransform>(); //Fetch Rect Transform from Game Object



		_Task.fontSize = 22;	
		_Task.font = _font;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(taskNew) // If new task is given to the player, do following: 
		{

			var randomSelector = Random.Range(1, jobs.Length);
			
			Debug.Log(jobs[randomSelector]);
			givenTask = randomSelector; //Gives player a task

			_Task.text = jobs[randomSelector]; //changes the text on a sticky note
			_Task.fontStyle = FontStyles.Normal;
			_Task.faceColor = new Color32(171, 17, 17, 255);




				//LerpTaskAnimationValue = LerpTaskAnimationValue * LerpTaskAnimationSmooth * Time.deltaTime;
				//this.gameObject.transform.localScale = Vector3.Lerp(LerpTaskAnimationStart,LerpTaskAnimationEnd,Time.deltaTime);




			taskNew = false;
		}

		if(taskAccomplished)
		{
			_Task.color = Color.yellow;
			_Task.fontStyle = FontStyles.Strikethrough;
			
			taskAccomplished = false;
		}

	}
}
