using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningScript : MonoBehaviour
{
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
            movement.z += speed;
        }

        if (Input.GetKey(Back))
        {
            movement.z -= speed;
        }

        if (Input.GetKey(Left))
        {
            movement.x -= speed;
        }

        if (Input.GetKey(Right))
        {
            movement.x += speed;
        }


        Vector3 newPosition = transform.position;

        newPosition += movement;

        transform.position = newPosition;
    }
}
