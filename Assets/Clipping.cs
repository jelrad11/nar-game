using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


void LateUpdate() {
    var point = Camera.main.WorldToScreenPoint(transform.position);
    float topMaxPosition = 380; // the top max position for any sprite in the screen
    sortingGroup.sortingOrder = Mathf.RoundToInt(topMaxPosition - point.y);
}
}
