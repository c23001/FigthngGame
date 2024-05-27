using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public  Rigidbody PLRB;
    int  sp = 5;
    int jumpPower = 500;
    void Start()
    {
        GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            PLRB.AddForce(transform.forward * sp);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PLRB.AddForce(-transform.forward * sp);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PLRB.AddForce(-transform.right * sp);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PLRB.AddForce(transform.right * sp);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PLRB.AddForce(transform.up * jumpPower);
        }
    }
}
