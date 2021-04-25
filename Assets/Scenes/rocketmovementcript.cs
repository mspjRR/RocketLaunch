using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketmovementcript : MonoBehaviour
{
    Rigidbody rb;
    [SerializedField]
    float thrust;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RocketFly();
    }
    private void RocketFly()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(Vector3.up * thrust);
            { 
                print("up"); 
            }
        }
        else
        {

        }
    }
}
