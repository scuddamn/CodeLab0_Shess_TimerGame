using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningScript : MonoBehaviour
{
    //set speed - didn't make a public var so that I could override with a 'sprint' key
    float Speed = 0.1f;

    //set sprint speed
    float Sprint = 0.5f;

    //set obj-specific movement keys
    public KeyCode Forward;
    public KeyCode Back;
    public KeyCode Right;
    public KeyCode Left;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();

        if (Input.GetKey(Forward))
        {
            movement.x -= Speed; //orientation is strange, but this does successfully move the player obj forward
        }

        if (Input.GetKey(Back))
        {
            movement.x += Speed; //move player obj backwards along x axis
        }

        if (Input.GetKey(Left))
        {
            movement.z -= Speed; //move player obj left along z axis
        }

        if (Input.GetKey(Right))
        {
            movement.z += Speed; //move player obj right along z axis
        }

        //create sprint speed override
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = Sprint;
        } else
        {
            Speed = 0.1f;
        }


        //move player obj according to key input
        Vector3 newPosition = transform.position;

        newPosition += movement;

        transform.position = newPosition;
    }
}
