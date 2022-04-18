using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialToggler : MonoBehaviour
{
    public Material[] materials;
    public GameObject character;
    public string targetTag;
    private GameObject[] targets;



    private int currentMaterialIndex = 0;


    int minInteractionDistance = 100;

    void Start()
    {
        //if targetTag is not empty, search all gameObjects with that tag
        if (targetTag != "")
        {
            print("Cantidad de materiales: " + materials.Length);

            print("targetTAG: " + targetTag);
            targets = GameObject.FindGameObjectsWithTag(targetTag);
            print("Cantidad con tag: " + targets.Length);
        }
        // set targets to an empty list
        else
        {
            targets = new GameObject[0];
        }
    }

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.transform.TransformDirection(Vector3.forward), out hit, minInteractionDistance))
        {

            Debug.Log("Material Toggler: " + hit.transform.name);
            if ((Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("Fire1")) && hit.transform.tag == tag)
                ShowNextMaterial(hit.transform.tag, hit.transform.name);
        }

        // loop through all materials
        for (int i = 0; i < materials.Length; i++)
        {
            if (materials[i].name == transform.GetComponent<Renderer>().material.name)
            {
                currentMaterialIndex = i;
            }
        }

    }

    private void ShowNextMaterial(string tag, string name)
    {
        currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
        //if targets has elements then change all targets to the next material
        if (targets.Length > 0)
        {
            print("target hit with tag: " + tag);
            print("Ammount of objects to change: " + targets.Length);
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].GetComponent<Renderer>().material = materials[currentMaterialIndex];
            }
        }
        else
        {
            transform.GetComponent<Renderer>().material = materials[currentMaterialIndex];
        }
    }


}