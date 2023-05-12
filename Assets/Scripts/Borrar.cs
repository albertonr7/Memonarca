using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borrar : MonoBehaviour
{
    public float tiempoBorrar = 1f;

    void Start()
    {
        Destroy(this.gameObject, tiempoBorrar);        
    }
}
