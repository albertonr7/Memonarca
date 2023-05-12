using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Carga : MonoBehaviour
{
    public AudioClip sonido;
    public AudioSource fuente;
    private bool dibujo = false;

    /* Verifica si es la primera vez que se carga una pantalla
    // En el caso de la primer carga desactiva el sonido en caso contrario lo reproduce*/
    IEnumerator Start()
    {
        Debug.Log("Showing splash screen");
        while (!SplashScreen.isFinished)
        {
            dibujo = true;
            SplashScreen.Draw();
            yield return null;
        }
        if(dibujo == true)
        {
            fuente.clip = sonido;
            fuente.playOnAwake = false;
        }
        else
        {
            fuente.PlayOneShot(sonido);
        }
        Debug.Log("Finished showing splash screen");

    }
}
