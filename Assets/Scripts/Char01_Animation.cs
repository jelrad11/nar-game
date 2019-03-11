using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char01_Animation : MonoBehaviour
{
    public Animator _animator;
    public bool running;

    public bool crawling;


    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Running", true);          
    }

    void Update()
    {
        if(crawling)
        {
            _animator.SetBool("crawling", true);
        }
        else
        {
          _animator.SetBool("crawling", false);  
        }
    }
}
