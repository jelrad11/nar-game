using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int LevelToLoad;

    
    private void OnTriggerStay(Collider col)
    {
        Debug.Log("hrac stoji u dveri");

        if(Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }

}
