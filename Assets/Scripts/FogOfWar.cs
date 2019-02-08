using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWar : MonoBehaviour
{
    // Start is called before the first frame update

    public bool fogOfWar = false;
    private bool fogOfWarEnabled = true;
    [SerializeField] Color Faded;

    Renderer _fogOfWarMaterial;
    private float _FadeTime = 1f;

void start()
{
}
    public void fade()
    {
        
        Debug.Log("Fadeeeeeeeeeeeeeeeeeeeeeeeeee");
        
    }
}


//If player enters area with fogOfWar enabled, 
// Disable fogOfWarEnabled 