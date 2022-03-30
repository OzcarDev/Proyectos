using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button : MonoBehaviour
{
    public Text pantalla;
    public string value;

    private void Start()
    {
        pantalla = GameObject.Find("PantallaText").GetComponent<Text>();
    }

    public void Pressed()
    {
        if (!Globals.on) return;
        if (pantalla.text.Equals( "0")|| Globals.res)
        {

            pantalla.text = value;
            Globals.res = false;
        }
        else
        {
            pantalla.text += value;
        }
    }
}
