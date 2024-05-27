using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ENLookatSC : MonoBehaviour
{
    public Transform Target;
    bool flag = true;
        
    void Update()
    {
        if(flag)
        {
             transform.LookAt(Target);
        }
        
    }
}