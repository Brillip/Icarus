using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredController : MonoBehaviour
{

    public float walkSpeed = 2f;
    public float rotationSpeed = 60f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) 
        {
            transformVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transformVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            transformVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transformVector += Vector3.right;
        }

        if (Input.GetKey(KeyCode.Q)) 
        {
            transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.E)) 
        {
            transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * rotationSpeed);
        }

        transformVector = transform.rotation * ((walkSpeed * Time.deltaTime) * transformVector);

        rb.MovePosition(transform.position + transformVector);
    }
}
