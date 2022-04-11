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



    // Use this for initialization
    void Start()
    {
        print("CameraScript Running");
    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        

        Vector3 cameraVector = Camera.main.transform.forward;
        float forwardMotion = Input.GetAxis("Vertical");
        // print(forwardMotion);
        cameraVector = new Vector3(cameraVector.x, 0, cameraVector.z);
        transform.position += forwardMotion * cameraVector * currentSpeed * 0.01f;
    }

}