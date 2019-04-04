using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Day : MonoBehaviour {

	public TextMeshProUGUI _dayText;  //Find the text
	 public Clock _clock;	//Handle for script Clock
	

	
	[SerializeField] GameObject calendarCross;	//GameObject Calendar Cross for Instantiating
	//private Vector3 _CrossPosDefault = new Vector3(-28.444f,11.531f,3.324f); //Offset for crosses in line -28.034
	private Vector3 _CrossOffsetLine = new Vector3(-0.184f,0,0); //Offset for crosses in line
	private Vector3 _CrossOffsetColumn = new Vector3(0,-0.231f,0); //Offset for crosses in column

	[SerializeField]private int _CrossInst; //Integer for checking if day++ -23.795


	public int DayLimit = 28;
	[SerializeField] private int _DayWeek;
	[SerializeField]private int _DayMonth; //Counts and sorts the days


	void Start () {
		_clock.dayAmount = 1;
		_DayMonth++;
		_DayWeek = 1;
	}

	void Update () {
		_dayText.text = ("Day " + _clock.dayAmount);

		if(_DayWeek >=8)
		{
			_DayWeek = 1;
		}

		if(_clock.crossReady) //Checks if CrossRready is true / if crosses are ready to spawn
		{



			if(_DayMonth <= 7 && _DayMonth >= 1) //If the crosses reach the end, it starts inst on the next line 
			{
				Instantiate(calendarCross, this.gameObject.transform.position  + (-_DayWeek) * _CrossOffsetLine, Quaternion.identity);
				
				
				_clock.crossReady = false;
			}

			if(_DayMonth <= 14  && _DayMonth >= 8)
			{
				Instantiate(calendarCross, this.gameObject.transform.position + (-_DayWeek) * _CrossOffsetLine + _CrossOffsetColumn,Quaternion.identity);

				
				_clock.crossReady = false;
			}
			
			if(_DayMonth <= 21 && _DayMonth >= 15)
			{
				Instantiate(calendarCross, this.gameObject.transform.position + (-_DayWeek) * _CrossOffsetLine + _CrossOffsetColumn * 2.1f,Quaternion.identity);

				
				_clock.crossReady = false;
			}
			
			if(_DayMonth <= 28 && _DayMonth >= 22)
			{
				Instantiate(calendarCross, this.gameObject.transform.position + (-_DayWeek) * _CrossOffsetLine + _CrossOffsetColumn * 3.25f,Quaternion.identity);

				_clock.crossReady = false;
			}

			_DayMonth++;
			_DayWeek++;



		}






		
	}
}
