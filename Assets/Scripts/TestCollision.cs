﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        Debug.Log("Contacto");
    }

    void OnCollisionExit()
    {
        Debug.Log("No contacto");
    }

    void OnCollisionStay()
    {
        Debug.Log("Está en contacto");
    }
}
