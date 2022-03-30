using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public Text pantalla;
    double resultado;


    private void Start()
    {
        pantalla = GameObject.Find("PantallaText").GetComponent<Text>();
    }


    public void Clear()
    { if (!Globals.on) return;
        Globals.num1 = 0;
        Globals.num2 = 0;
        Globals.operation = null;
        pantalla.text = "0";
        Globals.res = false;
    }

    public void On()
    {
        Globals.on = true;
        Clear();
      
    }

    public void Off()
    {
        Clear();
        pantalla.text = "";
        Globals.on = false;
    }
    public void Pressed()
    {
        if (!Globals.on) return;
        Globals.num2 = double.Parse(pantalla.text);

        

        switch (Globals.operation)
        {
            case "+":
                Suma();
                Debug.Log("Suma");
                break;

            case "-":
                Resta();
                break;

            case "*":
                Producto();
                break;

            case "/":
                Division();
                break;

            case null:
                Globals.num1 = double.Parse(pantalla.text);
                pantalla.text = Globals.num1.ToString();
                break;

        }


    }

    void Suma()
    {
        resultado = Globals.num1 + Globals.num2;
        pantalla.text = resultado.ToString();
        Globals.operation = null;
        Globals.res = true;
    }

    void Resta()
    {
        resultado = Globals.num1 - Globals.num2;
        pantalla.text = resultado.ToString();
        Globals.operation = null;
        Globals.res = true;
    }

    void Producto()
    {
        resultado = Globals.num1 * Globals.num2;
        pantalla.text = resultado.ToString();
        Globals.operation = null;
        Globals.res = true;
    }

    void Division()
    {
        resultado = Globals.num1 / Globals.num2;
        pantalla.text = resultado.ToString();
        Globals.operation = null;
        Globals.res = true;
    }
}
