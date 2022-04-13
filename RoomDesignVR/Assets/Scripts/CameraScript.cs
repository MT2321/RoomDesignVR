using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float speedH = 1.0f;
    public float speedV = 1.0f;
    public float currentSpeed = 1.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private bool move = false;
    private bool toggled = false;



    // Use this for initialization
    void Start()
    {
        print("CameraScript Running");
    }

    // Update is called once per frame
    void Update()
    {  
        Vector3 cameraVector = Camera.main.transform.forward;
        //int forwardMotion = (int)(Input.GetAxis("Vertical"));
        if(cameraVector.y < -0.7 && toggled == false)
        {
            toggle_move();
            toggled = true;
        }
        else
        {
            toggled = false;
        }

        if (move == true)
        {
            cameraVector = new Vector3(cameraVector.x, 0, cameraVector.z);
            transform.position += cameraVector * currentSpeed * Time.deltaTime;
        }
    }

    void toggle_move()
    {
        if(move == false)
        {
            move = true;
        }
        else
        {
            move = false;
        }
    }

}

