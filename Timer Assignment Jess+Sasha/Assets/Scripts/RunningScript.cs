using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningScript : MonoBehaviour
{
    // set up speed var and obj-specific movement 
    public float speed; 
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
            movement.x -= speed; //orientation is strange, but this does successfully move the player obj forward
        }

        if (Input.GetKey(Back))
        {
            movement.x += speed; //move player obj backwards along x axis
        }

        if (Input.GetKey(Left))
        {
            movement.z -= speed; //move player obj left along z axis
        }

        if (Input.GetKey(Right))
        {
            movement.z += speed; //move player obj right along z axis
        }


        //move player obj according to key input
        Vector3 newPosition = transform.position;

        newPosition += movement;

        transform.position = newPosition;
    }
}
