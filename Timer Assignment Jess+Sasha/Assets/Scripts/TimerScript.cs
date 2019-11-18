using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject timerObject; //var for timer itself
    Text timerTextComp; //variable for text component
    int timer = 0; //starting timer value
    // Start is called before the first frame update
    void Start()
    {
        timerTextComp = timerObject.GetComponent<Text>(); 
        timerTextComp.text = "0"; 
        InvokeRepeating("UpdateText", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateText()
    {
        timer++; //increase the timer
        timerTextComp.text = "Time: " + timer; 
    }

    public void StopTimer()
    {
        CancelInvoke();
    }
}
