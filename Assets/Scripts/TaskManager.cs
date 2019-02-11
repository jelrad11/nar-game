using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour {
	public TMP_FontAsset _font;
	
	[SerializeField]
	private TextMeshProUGUI _Task;

	public bool taskNew;
	public bool taskAccomplished;
	public bool taskWorking;
	public int taskWorkingID;
	public int givenTask;
	public int tasksFinished;

	 [System.NonSerialized] public string[] jobs = {  
		 				"Out",
		 				"Go to your office", 
	 					"Go to your colleagues office",
						"Go to the Boss",
						"Go to the meeting room",
						"Go for a lunch with your colleagues"};
	 
	// Use this for initialization
	void Start () {
		//Text
		_Task = GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>();

		_Task.fontSize = 18;	
		_Task.font = _font;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(taskNew)
		{

			var randomSelector = Random.Range(1, jobs.Length);
			
			Debug.Log(jobs[randomSelector]);
			givenTask = randomSelector; //Gives player a task

			_Task.text = jobs[randomSelector]; //changes the text on a sticky note
			_Task.fontStyle = FontStyles.Normal;
			_Task.faceColor = new Color32(171, 17, 17, 255);
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
