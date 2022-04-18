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
        pantalla = GameObject.Find("PantallaText").GetComponent<Text>();//Obtiene el texto del objeto pantalla
    }


    public void Clear()//reinicia todas las variables
    { if (!Globals.on) return;//si la calculadora esta apagada no hace nada
        Globals.num1 = 0;//reinicia la variable num1
        Globals.num2 = 0;//reinicia la variable num2
        Globals.operation = null;// reinicia el operador
        pantalla.text = "0";// Escribe 0 en la pantalla
        Globals.res = false;// Indica que no hay un numero recidual 
    }

    public void On()//enciende la calculadora
    {
        Globals.on = true;//pone la variable de encendido en verdadero
        Clear();//Reinicia las variables
      
    }

    public void Off()//Apaga la calculadora
    {
        Clear();//Reinicia las variables
        pantalla.text = "";//Deja en blanco la pantalla
        Globals.on = false;//Pone la variable de encendido en falso
    }
    public void Pressed()
    {
        if (!Globals.on) return;//Si esta apagada la calculadora no hace nada
        Globals.num2 = double.Parse(pantalla.text);//Asigna a la variable num2 el numero en pantalla

        

        switch (Globals.operation)//Casos distintos dependiendo el operando
        {
            case "+":
                Suma();//Si es suma se llama al metodo suma
                
                break;

            case "-":
                Resta();//Si es resta se llama al metodo resta
                break;

            case "*":
                Producto();// Si es multiplicación se llama al metodo producto
                break;

            case "/":
                Division();// Si es una división se llama al metodo division
                break;

            case null:
                Globals.num1 = double.Parse(pantalla.text); // Si el operando es nulo asigna a la variable num1 el numero en pantalla
                pantalla.text = Globals.num1.ToString();   // Si el operando es nulo reescribe la respuesta pasada
                break;

        }


    }

    void Resultado()
    {
        if (resultado>99999)//Si el resultado excede los 5 digitos manda un mensaje de error
        {
            pantalla.text = "ERROR";//Imprime mensaje de error
        }
    }

    void Suma()// Sumar
    {
        resultado = Globals.num1 + Globals.num2;//Suma la variable num1 y num2
        pantalla.text = resultado.ToString();//Escribe el resultado en la pantalla
        Resultado();//Verifica si el resultado excede los 5 digitos
        Globals.operation = null;//Resetea el operador
        Globals.res = true;//Marca que existe un residuo en la pantalla
    }

    void Resta()// Restar
    {
        resultado = Globals.num1 - Globals.num2;// Resta la variable num1 y num2
        pantalla.text = resultado.ToString();//Escribe el resultado en la pantalla 
        Resultado();//Verifica si el resultado excede los 5 digitos
        Globals.operation = null;//Resetea el operador
        Globals.res = true;//Marca que existe un residuo en pantalla
    }

    void Producto()//Multiplicación
    {
        resultado = Globals.num1 * Globals.num2;//Multiplicación entre num1 y num2
        pantalla.text = resultado.ToString();//Escribe el resultado en la pantalla
        Resultado();//Verifica si el resultado excede los 5 digitos
        Globals.operation = null;//Resetea el operador
        Globals.res = true;//Marca que existe un residuo
    }

    void Division()//Dividir
    {
        resultado = Globals.num1 / Globals.num2;//Divide num1 entre num2
        pantalla.text = resultado.ToString();//Escribe el resultado en la pantalla
        Resultado();//Verifica si el resultado excede los 5 digitos
        Globals.operation = null;//Resetea el operador
        Globals.res = true;//Marca que existe un residuo
    }
}
