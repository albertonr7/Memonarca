using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Imagenes : MonoBehaviour
{
    public Sprite imagen;
    public GameObject canva;
    private Button boton;
    public TextMeshProUGUI textoAutor;
    public string autor;

    // Muestra imagene en canva
    public void CambiarImagen()
    {
        canva.GetComponent<Image>().sprite = imagen;
        textoAutor.text = autor;
    }

}
