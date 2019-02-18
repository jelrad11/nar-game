using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char01_Animation : MonoBehaviour
{
    public Animator _animator;
    public bool running;


    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Running", true);          
    }
}
