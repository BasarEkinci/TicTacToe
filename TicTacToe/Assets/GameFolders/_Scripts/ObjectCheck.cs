using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCheck : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        name = other.name;
        Debug.Log(name);
    }
    
}
