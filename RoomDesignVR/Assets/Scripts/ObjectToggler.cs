using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    public GameObject character;
    public string tag_ext = "";
    private int minInteractionDistance = 4;
    private GameObject[] gos;
    private int currentVisibleObject = 0;
    private int hola = 0;
    void Start()
    {
        print("Object Toggler Running");
        gos = GameObject.FindGameObjectsWithTag(tag_ext);
        Debug.Log("Cantidad con tag_ext: " + tag_ext + " " + gos.Length);
        currentVisibleObject = 0;
        for (int i = 1; i < gos.Length; i++)
        {
            if (gos[i].name != this.transform.name)
                SetVisibility(gos[i], false);
        }
    }

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.transform.TransformDirection(Vector3.forward), out hit, minInteractionDistance))
        {
            //Debug.Log("Object Toggler: " + hit.transform.name);
            if (Input.GetKeyDown(KeyCode.M) && hit.transform.tag == tag_ext)
                ShowNextObject(hit.transform.tag, hit.transform.name);
        }
    }

    private void ShowNextObject(string tag_ext, string name)
    {
        Debug.Log("Toggling " + currentVisibleObject);
        GameObject g_old_object = gos[currentVisibleObject];
        SetVisibility(g_old_object, false);
        currentVisibleObject = (currentVisibleObject + 1) % gos.Length;
        Debug.Log("Toggling " + currentVisibleObject);
        GameObject g_new_object = gos[currentVisibleObject];
        SetVisibility(g_new_object, true);
    }

    private void SetVisibility(GameObject g, Boolean state)
    {
        g.active = state;
    }
}