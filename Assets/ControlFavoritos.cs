using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlFavoritos : MonoBehaviour
{
    public Image imagen;
    public Sprite vacia;
    public Sprite llena;
    private bool esFavorito = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ToggleFavorito()
    {
        esFavorito = !esFavorito;
        
        if (esFavorito)
        {
            imagen.sprite = llena;
        }
        else
        {
            imagen.sprite = vacia;
        }        
    }
}
