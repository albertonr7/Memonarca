using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ManejadorCartas : MonoBehaviour
{
    public static ManejadorCartas instance;
    
    public List<Sprite> ListaSprites = new List<Sprite>();

    [SerializeField]private List<GameObject> ListaBotones = new List<GameObject>();
    [SerializeField]private List<GameObject> ListaOcultarBotones = new List<GameObject>();
    
    private List<GameObject> CartaSeleccionada = new List<GameObject>();

    private int UltimaEleccionId;
    [SerializeField]private bool eleccion;
    [Header("Cuantos pares quieres jugar?")]
    //public int pares;

    [Header("Prefab Carta Boton")]
    public GameObject prefabCarta1;
    public GameObject prefabCarta2;

    // -- Arreglo reverso de cartas
    [Header("Lista Reverso Cartas")]
    public List<GameObject> ListaPrefabCartas1 = new List<GameObject>();
    public List<GameObject> ListaPrefabCartas2 = new List<GameObject>();

    [Header("Espacio para poner las cartas")]
    public Transform espacio;

    [Header("Puntuación por partida")]
    public int puntuacion = 100;

    public int eleccion1;
    public int eleccion2;

    [Header("Efectos")]
    public GameObject fxMariposas;

    // New
    bool activo;
    public Canvas canvas;
    public Canvas canvasActual;

    [Header("Texto")]
    public TextMeshProUGUI textoFinal;
    public TextMeshProUGUI textoPuntajeFinal;
    private int puntaje;
    public TextMeshProUGUI textoFinalP;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;

    void Awake()
    {
        instance = this;
    }

    // Iniciar script
    void Start()
    {
        LlenarTablero();
    }

    // Llenar tablero
    void LlenarTablero()
    {
        int pares = PlayerPrefs.GetInt("Pares");
        for(int i = 0; i < (pares*2); i++)
        {
            if((i % 2) == 0)
            {
                GameObject nuevaCarta = Instantiate(ListaPrefabCartas1[PlayerPrefs.GetInt("Cartas")], espacio);
                ListaBotones.Add(nuevaCarta);
                ListaOcultarBotones.Add(nuevaCarta);
            }
             else
            {
                GameObject nuevaCarta = Instantiate(ListaPrefabCartas2[PlayerPrefs.GetInt("Cartas")], espacio);
                ListaBotones.Add(nuevaCarta);
                ListaOcultarBotones.Add(nuevaCarta);
            }
        }
        CartasAleatorias();
    }

    // Asignar ID a las cartas e imagen de mariposa
    void CartasAleatorias()
    {
        int num = 0;
        int paresCartas = ListaBotones.Count / 2;

        // Lista desordenada
        List<Sprite> ListaSpritesDesordenada = new List<Sprite>();

        //randNum = Random();
        while(ListaSprites.Count > 0)
        {
            int val = Random.Range(0, ListaSprites.Count);
            ListaSpritesDesordenada.Add(ListaSprites[val]);
            ListaSprites.RemoveAt(val);
        }

        for(int i = 0; i < paresCartas; i++)
        {
            num++;
            // Cuenta cantidad de tarjeta por partida
            for (int j = 0; j < 2; j++)
            {
                int indexCartas = Random.Range(0, ListaBotones.Count);
                Cartas tempCartas = ListaBotones[indexCartas].GetComponent<Cartas>();
                tempCartas.id = num;
                tempCartas.cartaDelante = ListaSpritesDesordenada[num - 1];
                //tempCartas.cartaDelante = Random.Range(0, ListaSprites[num - 1]);
                ListaBotones.Remove(ListaBotones[indexCartas]);
            }
        }
    }

    public void AgregarCartaSeleccionada(GameObject carta)
    {
        CartaSeleccionada.Add(carta);
    }
   
    public IEnumerator CompararCartas()
    {
        if(eleccion2 == 0 || eleccion)
        {
            yield break;
        }
        eleccion = true;

        // Son iguales
        if((eleccion1 != 0 && eleccion2 != 0) && (eleccion1 != eleccion2))
        {
            yield return new WaitForSeconds(1.5f);
            // Voltear cartas a su posicion inicial
            VoltearCartas();
            // Reset puntos extra por combo
            ManejadorPuntos.instance.ReiniciarCombo();
        }
        else if((eleccion1 != 0 && eleccion2 != 0) && (eleccion1 == eleccion2))
        {
            yield return new WaitForSeconds(.5f);
            UltimaEleccionId = eleccion1;
            // Añadir puntaje
            ManejadorPuntos.instance.AgregarPuntaje(puntuacion);
            // Remover el par
            RemoverPar();
            // Limpiar cartas seleccionadas
            CartaSeleccionada.Clear();
        }
        // Resetear todas las opciones
        eleccion1 = 0;
        eleccion2 = 0;
        eleccion = false;

        // Revisar si gana
        ComprobarGanar();
    }

    void VoltearCartas()
    {
        foreach(GameObject carta in CartaSeleccionada)
        {
            carta.gameObject.GetComponent<Cartas>().CerrarCartas();
        }
        CartaSeleccionada.Clear();
    }

    void RemoverPar()
    {
        for(int i = ListaOcultarBotones.Count - 1; i >= 0; i--)
        {
            Cartas tempCartas = ListaOcultarBotones[i].GetComponent<Cartas>();
            if(tempCartas.id == UltimaEleccionId)
            {
                // Efecto mariposas
                Instantiate(fxMariposas, ListaOcultarBotones[i].transform.position + new Vector3(0, 0, -2), Quaternion.identity);
                // Remover Carta
                ListaOcultarBotones.RemoveAt(i);
            }  
        }
    }

    void ComprobarGanar()
    {
        if(ListaOcultarBotones.Count < 1)
        {
            // Detener tiempo
            ManejadorPuntos.instance.DetenerTiempo();
            // Esconde escenario
            canvasActual.enabled = false;
            // Mostrar algo
            canvas.enabled = true;
            // Efectos
            Instantiate(fxMariposas, canvas.transform.position + new Vector3(0, 0, -2), Quaternion.identity);
            // Mostrar puntaje final
            puntaje = int.Parse(textoPuntajeFinal.text);
            Puntuacion();
        }
    }

    public void Salir(string nombreEscena){
        Continuar();
        SceneManager.LoadScene(nombreEscena);
    }

    // Recarga la escena actual
    public void ReiniciarNivel()
    {
        Continuar();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);       
    }

    // Continua el tiempo de partida y esconde el menú de pausa
    public void Continuar(){
        //activo = !activo;
        canvasActual.enabled = activo;
        Time.timeScale = (activo) ? 0 : 1f;
    }

    // Calcula la pantalla final
    private void Puntuacion()
    {
        switch(PlayerPrefs.GetInt("Pares"))
        {
            case 8:
                if(puntaje >= 160 && puntaje < 240)
                {
                    minimo();
                }
                else if(puntaje >= 240 && puntaje < 290)
                {
                    medio();
                }
                else if(puntaje >= 290)
                {
                    maximo();
                }
            break;
            case 10:
                if(puntaje >= 200 && puntaje < 280)
                {
                    minimo();
                }
                else if(puntaje >= 280 && puntaje < 330)
                {
                    medio();
                }
                else if(puntaje >= 330)
                {
                    maximo();
                }
            break;
            case 12:
                if(puntaje >= 240 && puntaje < 320)
                {
                    minimo();
                }
                else if(puntaje >= 320 && puntaje < 450)
                {
                    medio();
                }
                else if(puntaje >= 450)
                {
                    maximo();
                }
            break;
        }
    }

    private void minimo()
    {
        textoFinal.text = "¡Lo lograste!";
        textoFinalP.text = "Puntuación:" + puntaje.ToString();
        estrella2.GetComponent<Image>().color = new Color(0, 0, 0, .40f);
        estrella3.GetComponent<Image>().color = new Color(0, 0, 0, .40f);
    }

    private void medio()
    {
        textoFinal.text = "¡Buen trabajo!";
        textoFinalP.text = "Puntuación:" + puntaje.ToString();
        estrella3.GetComponent<Image>().color = new Color(0, 0, 0, .40f);
    }

    private void maximo()
    {
        textoFinal.text = "¡Excelente!";
        textoFinalP.text = "Puntuación:" + puntaje.ToString(); 
    }

}
