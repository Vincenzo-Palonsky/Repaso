using System.Collections;
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

    /*Requisitos para las colisiones:
    1. Los elementos que participen en la colision tengan un collider. Este es el equivalente al hitbox. Este no tiene que tener activada la opción "Is Trigger".
    2. Alguno de los objetos debe tener rigidbody, con la opcion "Is Kinematic" desactivada.
    3. Una función OnCollision.*/

    //alinear camara con lo que estamos viendo: selecionamos la cámara y control + shift + F
}
