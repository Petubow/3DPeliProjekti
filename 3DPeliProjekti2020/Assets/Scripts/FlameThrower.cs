﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetBool("FTON", true);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Animator>().SetBool("FTON",false);
           
        }

      
    }

    
}
