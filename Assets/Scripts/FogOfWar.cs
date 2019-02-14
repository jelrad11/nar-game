using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWar : MonoBehaviour
{
    // Start is called before the first frame update

    [System.NonSerialized] public int fogOfWar = 0;
    public bool fogOfWarEnabled = true;
    public bool fogOfWarAnimating = false;
    public float _t = 0f;
    
    [SerializeField] Color FadeStartColor;
    [SerializeField] Color FadeEndColor;
    private float _FadeTime = 1f;

    Renderer _fogOfWarMaterial;
    void Update()
    {
        if(fogOfWar == 1 && fogOfWarAnimating)
        {
            fade();
        }

        if(fogOfWar == 2 && fogOfWarAnimating)
        {
            FadeEnd();
        }
    }

    public void fade()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(FadeStartColor, FadeEndColor, _t);
            if (_t < 1)
            {
                _t += Time.deltaTime / _FadeTime;
                Debug.Log(_t);
            }

            else
            {
                fogOfWarAnimating = false;
                _t = 0;
            }

    }

    public void FadeEnd()
    {
               GetComponent<Renderer>().material.color = Color.Lerp(FadeEndColor, FadeStartColor , _t);
            if (_t < 1)
            {
                _t += Time.deltaTime / _FadeTime;
            } 
            
            else {
                fogOfWarAnimating = false;
                _t = 0;
            }
    }
}


//If player enters area with fogOfWar enabled, 
// Disable fogOfWarEnabled 