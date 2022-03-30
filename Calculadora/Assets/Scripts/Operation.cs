using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
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
        Globals.num2 = 0;
        Globals.num1 = double.Parse(pantalla.text);
        Globals.res = true;
        Globals.operation = value;
              
        
    }
}
