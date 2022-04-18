using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
{
    public Text pantalla;
    public string value;//Valor del botón
    

    private void Start()
    {
        pantalla = GameObject.Find("PantallaText").GetComponent<Text>();//Obtiene el texto del objeto pantalla
    }
   

   public void Pressed()
    {
        if (!Globals.on) return;//Si esta apagada no hace nada
        Globals.num2 = 0;//Recetea la variable num2
        Globals.num1 = double.Parse(pantalla.text);//Guarda la pantalla en la varibale num1
        Globals.res = true;//Indica que hay un residuo en pantalla
        Globals.operation = value;//Asigna el operador presionado
              
        
    }
}
