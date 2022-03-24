using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ObjectSelectorV2 : MonoBehaviour
{
    public float pickUpRange = 2;
    public float modifyObject = 10;
    public Transform holdParent;
    private GameObject heldObject;

    private float moveForce = 30;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, modifyObject))
        {
            print("Checking Wall: " + hit.transform.tag);
            if (hit.transform.tag == "main_wall")
            {
                Material material = hit.transform.GetComponent<Renderer>().material;
                Debug.Log("El material es:");
            }
        }


        if (Input.GetKeyDown(KeyCode.G))
        {
            if (heldObject == null)
            {
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }

        }

        if (heldObject != null)
        {
            MoveObject();
        }
    }

    void PickupObject(GameObject pickObject)
    {

        if (pickObject.GetComponent<Rigidbody>())
        {
            Rigidbody objRigidBody = pickObject.GetComponent<Rigidbody>();
            objRigidBody.useGravity = false;
            objRigidBody.drag = 30;

            objRigidBody.transform.parent = holdParent;
            heldObject = pickObject;
            Vector3 vectorFromParent = (heldObject.transform.position - holdParent.transform.position).normalized;
            heldObject.transform.position = holdParent.transform.position + vectorFromParent * 0.5F;
        }
    }

    void DropObject()
    {

        heldObject.GetComponent<Rigidbody>().useGravity = true;
        heldObject.GetComponent<Rigidbody>().drag = 5;
        heldObject.transform.parent = null;
        heldObject = null;
    }

    void MoveObject()
    {
        if (Vector3.Distance(heldObject.transform.position, holdParent.transform.position) > 0.1f)
        {
            // Vector3 moveDirection = (holdParent.transform.position - heldObject.transform.position);
            // heldObject.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);
            Vector3 vectorFromParent = (heldObject.transform.position - holdParent.transform.position).normalized;
            heldObject.transform.position = holdParent.transform.position + vectorFromParent * 0.5F;

        }
    }
}