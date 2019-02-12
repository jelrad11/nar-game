using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWar : MonoBehaviour
{
    // Start is called before the first frame update

    public bool fogOfWar = false;
    private bool fogOfWarEnabled = true;
    
    [SerializeField] Color FadeStartColor;
    [SerializeField] Color FadeEndColor;
    private float _FadeTime = 1f;

    Renderer _fogOfWarMaterial;


    public void fade()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(FadeStartColor, FadeEndColor,1);
        Debug.Log("Fadeeeeeeeeeeeeeeeeeeeeeeeeee");
            
    }

    public void fadeEnd()
    {
        
    }
}


//If player enters area with fogOfWar enabled, 
// Disable fogOfWarEnabled 