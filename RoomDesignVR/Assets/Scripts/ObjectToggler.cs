using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    public GameObject character;

    private int minInteractionDistance = 1;
    private GameObject[] gos;
    private int currentVisibleObject = 0;
    void Start()
    {
        print("Object Toggler Running");
        gos = GameObject.FindGameObjectsWithTag(tag);
        Debug.Log("Cantidad con tag: " + tag + " " + gos.Length);

        for (int i = 0; i < gos.Length; i++)
        {
            if (gos[i].name != this.transform.name)
                SetVisibility(gos[i], false);
            else
            {
                currentVisibleObject = i;
            }
        }
    }

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.transform.TransformDirection(Vector3.forward), out hit, minInteractionDistance))
        {
            Debug.Log("Object Toggler: " + hit.transform.name);
            if (Input.GetKeyDown(KeyCode.G) && hit.transform.tag == tag)
                ShowNextObject(hit.transform.tag, hit.transform.name);
        }
    }

    private void ShowNextObject(string tag, string name)
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
        if (g.GetComponent<Collider>())
            g.GetComponent<Collider>().enabled = state;
        if (g.GetComponent<CapsuleCollider>())
            g.GetComponent<CapsuleCollider>().enabled = state;

        g.GetComponent<Renderer>().enabled = state;

    }


}