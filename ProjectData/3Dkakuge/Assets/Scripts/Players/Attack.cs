using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Player;
    public BoxCollider PlayerPhysic;
    float JabTimer;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            JabTimer += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.J) && JabTimer < 1)
        {
            Debug.Log("弱");
            JabTimer = 0;
        }
        else
        if (Input.GetKeyUp(KeyCode.J) && JabTimer > 1)
        {
            Debug.Log("ガードブレイク技");
            JabTimer = 0;
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("技1");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("技2");
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("ガード");
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            PlayerPhysic.material.dynamicFriction = 3.0f;
            Debug.Log("しゃがみ");
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            PlayerPhysic.material.dynamicFriction = 0.6f;
            Debug.Log("しゃがみ解除");
        }
    }
}
