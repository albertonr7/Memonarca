using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public float espera;

    // Recibe el nombre de la escena a la que se cambia y llama a la corutina
    public void opciones(string nombreEscena){
        //SceneManager.LoadScene(nombreEscena);
        StartCoroutine(esperarSegundos(nombreEscena, espera));
    }

    // Espera un segundo y cambia de escena
    IEnumerator esperarSegundos(string nombreEscena, float espera)
    {
        yield return new WaitForSeconds(espera);
        SceneManager.LoadScene(nombreEscena);
    }

    // Sale de la aplicación
    public void salir(){
        Application.Quit();
    }
    
}
