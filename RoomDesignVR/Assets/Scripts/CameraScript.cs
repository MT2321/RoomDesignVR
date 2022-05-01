using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    // public float speedH = 1.0f;
    // public float speedV = 1.0f;
    // public float currentSpeed = 1.0f;

    // private float yaw = 0.0f;
    // private float pitch = 0.0f;

    public Transform vrCamera;
    public float toggleAngle = 60.0f;
    public float speed = 3.0f;
    private bool moveForward;


    // Use this for initialization
    void Start()
    {
        // print("CameraScript Running");
    }

    // Update is called once per frame
    void Update()
    {

        if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if(moveForward)
        {
            Vector3 cameraVector = vrCamera.forward;
            cameraVector.y = 0.0f;
            transform.position += cameraVector * speed * Time.deltaTime;
        }

        //BORRAR
        // yaw += speedH * Input.GetAxis("Mouse X");
        // pitch -= speedV * Input.GetAxis("Mouse Y");

        // transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        // float currentSpeed = 0.1f;

        // Vector3 cameraVector = Camera.main.transform.forward;
        // float forwardMotion = Input.GetAxis("Vertical");
        // cameraVector = new Vector3(cameraVector.x, 0, cameraVector.z);
        // transform.position += forwardMotion * cameraVector * currentSpeed;
        //BORRAR



        // Vector3 cameraVector = Camera.main.transform.forward;
        // int forwardMotion = (int)(Input.GetAxis("Vertical"));
        // // print(forwardMotion);

        // cameraVector = new Vector3(cameraVector.x, 0, cameraVector.z);
        // transform.position += forwardMotion * cameraVector * currentSpeed;
    }

}