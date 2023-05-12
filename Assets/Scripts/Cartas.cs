using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cartas : MonoBehaviour
{
    [HideInInspector]public int id;
    public Sprite cartaAtras; //cardBack
    [HideInInspector]public Sprite cartaDelante; //cardFront

    private Image imagen;
    private Button boton;

    private bool seVeImagen; //IsFlippingOpen
    private bool noVeImagen; //IsFlippingClose
    private bool voltear; //Flipped
    private float cantidadVolteada = 1; //flipAmount

    public float velocidadVoltear = 4;  // flipSpeed
    
    void Start()
    {
        imagen = GetComponent<Image>();
        boton = GetComponent<Button>();    
    }

    // Voltear carta al hacer clic
    public void VoltearCarta()
    {
       if(ManejadorCartas.instance.eleccion1 == 0)
       {
            ManejadorCartas.instance.eleccion1 = id;
            ManejadorCartas.instance.AgregarCartaSeleccionada(this.gameObject);

            seVeImagen = true;
            StartCoroutine(VoltearAbrir());
            // Evitar que se pueda volver a clicar el botón
            boton.interactable = false;
       } 
       else if(ManejadorCartas.instance.eleccion2 == 0)
       {
            ManejadorCartas.instance.eleccion2 = id;
            ManejadorCartas.instance.AgregarCartaSeleccionada(this.gameObject);

            seVeImagen = true;
            StartCoroutine(VoltearAbrir());
            // Evitar que se pueda volver a clicar el botón
            boton.interactable = false;

            //Comparar las cartas
            StartCoroutine(ManejadorCartas.instance.CompararCartas());
       } 
    }

    // Abrir las cartas FlipOpen
    IEnumerator VoltearAbrir()
    {
        while(seVeImagen && cantidadVolteada > 0)
        {
            cantidadVolteada -= Time.deltaTime * velocidadVoltear;
            cantidadVolteada = Mathf.Clamp01(cantidadVolteada);
            transform.localScale = new Vector3(cantidadVolteada,transform.localScale.y,transform.localScale.z);
            if(cantidadVolteada <= 0)
            {
                imagen.sprite = cartaDelante;
                seVeImagen = false;
                noVeImagen = true;
            }
            yield return null;
        }

        while(noVeImagen && cantidadVolteada < 1)
        {
            cantidadVolteada += Time.deltaTime*velocidadVoltear;
            cantidadVolteada = Mathf.Clamp01(cantidadVolteada);
            transform.localScale = new Vector3(cantidadVolteada,transform.localScale.y,transform.localScale.z);
            if(cantidadVolteada >= 1)
            {
                noVeImagen = false;
            }
            yield return null;
        }

    }

    // Cerrar las cartas
    IEnumerator VoltearCerrar()
    {
        while(seVeImagen && cantidadVolteada > 0)
        {
            cantidadVolteada -= Time.deltaTime*velocidadVoltear;
            cantidadVolteada = Mathf.Clamp01(cantidadVolteada);
            transform.localScale = new Vector3(cantidadVolteada,transform.localScale.y,transform.localScale.z);
            if(cantidadVolteada <= 0)
            {
                imagen.sprite = cartaAtras;
                seVeImagen = false;
                noVeImagen = true;
            }
            yield return null;
        }

        while(noVeImagen && cantidadVolteada < 1)
        {
            cantidadVolteada += Time.deltaTime*velocidadVoltear;
            cantidadVolteada = Mathf.Clamp01(cantidadVolteada);
            transform.localScale = new Vector3(cantidadVolteada,transform.localScale.y,transform.localScale.z);
            if(cantidadVolteada >= 1)
            {
                noVeImagen = false;
            }
            yield return null;
        }
        boton.interactable = true;
    }

    // Close Card
    public void CerrarCartas()
    {
        seVeImagen = true;
        StartCoroutine(VoltearCerrar());
    } 

}
