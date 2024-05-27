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
            Debug.Log("é„");
            JabTimer = 0;
        }
        else
        if (Input.GetKeyUp(KeyCode.J) && JabTimer > 1)
        {
            Debug.Log("ÉKÅ[ÉhÉuÉåÉCÉNãZ");
            JabTimer = 0;
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("ãZ1");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("ãZ2");
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("ÉKÅ[Éh");
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            PlayerPhysic.material.dynamicFriction = 3.0f;
            Debug.Log("ÇµÇ·Ç™Ç›");
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            PlayerPhysic.material.dynamicFriction = 0.6f;
            Debug.Log("ÇµÇ·Ç™Ç›âèú");
        }
    }
}
