using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour

{


    public float moveSpeed = 3, forceAmount = 400;
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        //transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        //rigidBody.MovePosition(transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0));

       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(0, 400, 0);
        }
        */


    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collided with: " + collision.gameObject.name);
    }

}
