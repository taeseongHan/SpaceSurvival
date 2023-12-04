using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameManagerTaeseong : MonoBehaviour
{
    

    public static gameManagerTaeseong I;
    void Awake()
    {
        I = this;
    }


    void Start()
    {
        GameObject Character = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        
    }

    
}



