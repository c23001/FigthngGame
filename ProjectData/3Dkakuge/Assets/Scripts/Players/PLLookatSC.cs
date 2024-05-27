using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLLookatSC : MonoBehaviour
{
    public Transform Target;
    bool flag = true;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)  && !flag)
        {
            flag = false;
        }
        if (Input.GetKeyDown(KeyCode.P) && flag)
        {
            flag = true;
        }

        if (flag)
        {
            transform.LookAt(Target);
        }
        else
        {
            transform.LookAt(null);
        }
        Debug.Log(flag);
    }    
}
