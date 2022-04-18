using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    public GameObject character;
    public string tag_ext = "";
    private int minInteractionDistance = 100;
    private GameObject[] gos;
    private int currentVisibleObject = 0;
    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag(tag_ext);
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
            if ((Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1")) && hit.transform.tag == tag_ext)
                ShowNextObject(hit.transform.tag, hit.transform.name);
        }
    }

    private void ShowNextObject(string tag_ext, string name)
    {
        GameObject g_old_object = gos[currentVisibleObject];
        SetVisibility(g_old_object, false);
        currentVisibleObject = (currentVisibleObject + 1) % gos.Length;
        GameObject g_new_object = gos[currentVisibleObject];
        SetVisibility(g_new_object, true);
    }

    private void SetVisibility(GameObject g, Boolean state)
    {
        g.SetActive(state);
    }
}