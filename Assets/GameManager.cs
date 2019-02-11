using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TaskManager _TM;
    [SerializeField] private Clock _Cl;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( _Cl.timeEnabled == true)
        {
            if(_TM.taskLookingFor == true)
            {
                StartCoroutine("TaskTimer");
            }
        }
    }

    IEnumerator TaskTimer()
    {   
        
        Debug.Log("GameManager is looking for job for player");
        _TM.taskLookingFor = false;
        yield return new WaitForSeconds(10);


        Debug.Log("Player was given a new Task");
        _TM.taskLookingFor = true;
        _TM.taskNew = true;
    }
}

