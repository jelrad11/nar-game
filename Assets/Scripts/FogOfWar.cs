using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWar : MonoBehaviour
{
    // Start is called before the first frame update

    [System.NonSerialized] public bool fogOfWar = false;
    public bool fogOfWarEnabled = true;
    private float _t = 0f;
    
    [SerializeField] Color FadeStartColor;
    [SerializeField] Color FadeEndColor;
    private float _FadeTime = 1f;

    Renderer _fogOfWarMaterial;
    void Update()
    {
        if(fogOfWar)
        {
            fade();
        }
    }

    public void fade()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(FadeStartColor, FadeEndColor, _t);
            if (_t < 1)
            {
                _t += Time.deltaTime / _FadeTime;
            }
    }
}


//If player enters area with fogOfWar enabled, 
// Disable fogOfWarEnabled 