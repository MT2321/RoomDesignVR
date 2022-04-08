using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialToggler : MonoBehaviour
{
    public Material[] materials;
    public GameObject character;



    private int currentMaterialIndex = 0;


    public int minInteractionDistance = 1;

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.transform.TransformDirection(Vector3.forward), out hit, minInteractionDistance))
        {
            Debug.Log("Object Toggler: " + hit.transform.name);
            if (Input.GetKeyDown(KeyCode.G) && hit.transform.tag == tag)
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
        transform.GetComponent<Renderer>().material = materials[currentMaterialIndex];

    }


}