using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject myObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //    if (myObject.activeInHierarchy)
            //    {
            //        myObject.SetActive(false);
            //    }

            //    else
            //    {
            //        myObject.SetActive(true);
            //    }    
            myObject.SetActive(!myObject.activeInHierarchy);
        }    
    }
}
