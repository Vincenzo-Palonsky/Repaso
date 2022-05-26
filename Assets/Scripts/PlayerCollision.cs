using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(0, 1, 0);
        }
    }

    void OnCollisionExit()
    {
        transform.position = new Vector3(0, 1, 0);
    }
}
