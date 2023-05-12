using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Button))]
public class SonidosBotones : MonoBehaviour
{
    public AudioClip sonido;
    
    private AudioSource fuente
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }

    public void Boton()
    {
      gameObject.AddComponent<AudioSource>();
      fuente.clip = sonido;
      fuente.PlayOneShot(sonido);
    }


}
