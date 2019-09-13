using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFromCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, 1))
            {

                print("Hit object: " + hit.collider.gameObject.name);
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            } else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.green);
            }
           


        }

    }
}
