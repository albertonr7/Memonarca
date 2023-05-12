using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorNivel : MonoBehaviour
{
    // Función para regresar a la pantalla anterior
    public void Regresar()
    {
        StartCoroutine(Esperar(.1f, "Menu"));
    }

    // Función para avanzar a la escena del juego
    public void JuegoFacil()
    {
        PlayerPrefs.SetInt("Pares", 8);
        PlayerPrefs.SetInt("Cartas", 0);
        StartCoroutine(Esperar(.1f, "Juego"));
    }

    public void JuegoNormal()
    {
        PlayerPrefs.SetInt("Pares", 10);
        PlayerPrefs.SetInt("Cartas", 0);
        StartCoroutine(Esperar(.1f, "Juego"));
    }

    public void JuegoDificil()
    {
        PlayerPrefs.SetInt("Pares", 12);
        PlayerPrefs.SetInt("Cartas", 1);
        StartCoroutine(Esperar(.1f, "Juego"));
    }

    IEnumerator Esperar(float espera, string escena)
    {
        yield return new WaitForSeconds(espera);
        SceneManager.LoadScene(escena);
    }


}