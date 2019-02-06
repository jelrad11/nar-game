using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour {
	public Transform quarterHand;
	public Transform hourHand;
	private Day _Day;
	
	[SerializeField]
	private TaskManager _TM;

	

	private float _Time;

	public bool timeEnabled = false;

	private float timeSpeed = 0.5f;
	public int Quarters = -1;
	public int Hour = 0;
	public int dayAmount = 1;
	public bool crossReady = false; //Cross is ready to spawn

	private int _TimeValQuarter = 15;
	private int _CurrentTimeQuarter = 0;

	public Vector3 VectorA = new Vector3(0,0,0);
	public Vector3 VectorB = new Vector3(0,90,0);
	
	[SerializeField] string CurrentTime;

	void Awake()
	{	

	}		


	// Use this for initialization
	void Start () 
	{
		_TM = GameObject.FindGameObjectWithTag("Task Manager").GetComponent<TaskManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetKey(KeyCode.F) || timeEnabled == true )
		{
			quarterHand.Rotate(0,0,-90 * Time.deltaTime * 2 );
			hourHand.Rotate(0,0,-15 * Time.deltaTime);


			//Debug.Log(Mathf.RoundToInt(Time.time));
			timeEnabled = true;

			if(Time.time > _Time)
			{

				_Time = Time.time + timeSpeed;
				
				Quarters++;
				Debug.Log("Quarter " + Quarters);

				if(Quarters > 0)
				{
					Debug.Log("Hodina");	
				}	
			}

			if(Quarters >= 4)
			{
				Hour++;
				Quarters = 0;

				Debug.Log("Hour " + Hour); 
			}	
			
			if(Hour >= 12)
			{
				dayAmount++;
				Hour = 0;
				crossReady = true;
			}
			
			_CurrentTimeQuarter = Quarters * _TimeValQuarter;


			CurrentTime = (" " + Hour + " : " + _TimeValQuarter * Quarters);

		}
	
	}
}
