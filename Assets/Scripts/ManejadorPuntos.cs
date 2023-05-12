using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ManejadorPuntos : MonoBehaviour
{
    public static ManejadorPuntos instance;

    // Puntaje
    public int puntajeActual; // currentScore 

    // Combo
    private int comboActual; // currentComboAmount
    public int giroActual; // currentTurn

    // Tiempo de juego
    public int tiempoJuego;
    private int segundos;
    private int minutos;
    [Header("Conexión texto")]
    public TextMeshProUGUI textoTiempo;
    public TextMeshProUGUI textoPuntaje; 
    public TextMeshProUGUI textoCombo;
    public TextMeshProUGUI textoGiro;  

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ActualizaPuntaje();
        StartCoroutine("TiempoJuego");    
    }

    // Actualiza los puntajes, combos, giros y llama a la función que los actualiza en pantalla
    public void AgregarPuntaje(int puntuacion)
    {
        comboActual++;
        giroActual++;
        puntajeActual += puntuacion * comboActual;    
        ActualizaPuntaje();
    }

    // Reinicia el contador de Combo, añade un giro y llama a la función ActualizaPuntaje
    public void ReiniciarCombo()
    {
        comboActual = 0;
        giroActual++;
        ActualizaPuntaje();
    }

    // Actualiza la interfaz de usuario con lo puntajes, combos y giros
    void ActualizaPuntaje()
    {
        textoPuntaje.text = puntajeActual.ToString("F0");
    }

    // Cuenta el tiempo
    IEnumerator TiempoJuego()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            tiempoJuego++;
            segundos = (tiempoJuego % 60);
            minutos = (tiempoJuego / 60) % 60;
            ActualizaTiempo();
        }
    }
    
    // Actualiza elemento de la interfaz de usuario que muestra el tiempo de partida 
    void ActualizaTiempo()
    {
        textoTiempo.text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
    }

    // Detiene el contador de tiempo de partida
    public void DetenerTiempo()
    {
        StopAllCoroutines();
        StopCoroutine("TiempoJuego");
    }

}
