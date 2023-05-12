using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script para activar o desactivar el menú de pausa.
public class Pausa : MonoBehaviour
{

    bool activo;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        if(canvas != null)
        {
            Debug.Log("Aquí lo tengo");
        }
    }
    
    // Si el menú esta activo el tiempo es pausado (0) sino el tiempo se queda normal. 
    public void Pausar(){
        activo = !activo;
        canvas.enabled = activo;
        Time.timeScale = (activo) ? 0 : 1f;
    }

    public void Salir(string nombreEscena){
        Continuar();
        StartCoroutine(Esperar(.1f, "Menu"));
    }

    // Recarga la escena actual
    public void ReiniciarNivel()
    {
        Continuar();
        StartCoroutine(Esperar(.1f, "Juego"));       
    }

    // Continua el tiempo de partida y esconde el menú de pausa
    public void Continuar(){
        activo = !activo;
        canvas.enabled = activo;
        Time.timeScale = (activo) ? 0 : 1f;
    }

    IEnumerator Esperar(float espera, string escena)
    {
        yield return new WaitForSeconds(espera);
        SceneManager.LoadScene(escena);
    }
}
