﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTriggerScript : MonoBehaviour
{
    public TimerScript timerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //stop timer once finish line is hit
        if (other.CompareTag("Player"))
        {
           timerScript.CancelInvoke();
        }
       
    }
}
