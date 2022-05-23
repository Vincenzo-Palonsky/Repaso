using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlataforma : MonoBehaviour
{
    public GameObject baseIzq;
    public GameObject baseDer;
    public GameObject prefabEsfera;
    public GameObject prefabCilindro;
    public float velocidadPlataforma;
    bool movDerecha;
    GameObject clon;
    int yCilindro = 0;
    int yEsfera = 0;

    void Start()
    {
        movDerecha = true;
    }

    void Update()
    {
        if (movDerecha)
        {
            transform.position += new Vector3(velocidadPlataforma, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(velocidadPlataforma, 0, 0);
        }

        if (transform.position.x >= baseDer.transform.position.x-1.5)
        {
            movDerecha = false;
            clon = Instantiate(prefabCilindro);
            clon.transform.position = new Vector3(baseDer.transform.position.x, yCilindro, 0);
            yCilindro++;
        }

        else if (transform.position.x <= baseIzq.transform.position.x+1.5)
        {
            movDerecha = true;
            clon = Instantiate(prefabEsfera);
            clon.transform.position = new Vector3(baseIzq.transform.position.x, yEsfera, 0);
            yEsfera++;
        }
    }
}
