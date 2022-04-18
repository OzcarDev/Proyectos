using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button : MonoBehaviour
{
    public Text pantalla; //game object del texto que se usa como pantalla
    public string value; // valor del botón

    private void Start()
    {
        pantalla = GameObject.Find("PantallaText").GetComponent<Text>(); //se obtiene el texto de la pantalla
    }

    public void Pressed()
    {
        if (!Globals.on) return;//Si esta apagada la calculadora no hace lo demás
        if (pantalla.text.Equals( "0")|| Globals.res)//Revisa si la pantalla esta en 0 o si tiene un número anterior
        {

            pantalla.text = value;//Sobrescribe la pantalla
            Globals.res = false;//indica no existe un número anterior al actual
        }
        else
        {
            pantalla.text += value;//Añade un caracter nuevo a la pantalla
        }
    }
}
