using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataBase : MonoBehaviour
{
   
    public List<List<string>> questions = new List<List<string>>()
    {
      /*0*/   { new List<string>(){ "�Que es la programacion orientada a objetos?", "Es una forma especial de programar, m�s cercana a como expresariamos las cosas en la vida real que otros tipos de programaci�n.", "Programaci�n de celulares con objetos", "Es una forma de programar con objetos reales", "-Ninguna de las anteriores" } },
      /*1*/   { new List<string>(){ "Caracteristicas de la programaci�n orientada a objetos:", "Abstracci�n, encapsulamiento, principio de ocultaci�n, herencia y poliformia", "Objeto, programa y m�quina", "Atracci�n, repulsi�n, im�n ", "Herencia, programa, atracci�n" } },
      /*2*/   { new List<string>(){ "�Que es una subclase?", "La clase que proviene de otras clases ", "Es una variable", "Ninguna de las anteriores", "Tipo de programa en visual" } },
      /*3*/   { new List<string>(){ "�Que tipo de clases puedo hacer en java?", "P�blicas y privadas", "P�blicas y m�dulos", "Modulos", "Privadas" } },
      /*4*/   { new List<string>(){ "El comportamiento de un objeto son:", "Operaciones y m�todos", "Atributos f�sicos", "Atributos abstractos", "Ninguna de las anteriores" } },
      /*5*/   { new List<string>(){"Dentro de un conjunto de objetos existen diferentes formas y maneras de hacer las cosas", "Poliformismo", "Generalizaci�n", "Herencia", "Abstracci�n" } },
      /*6*/   { new List<string>(){ "Una superclase es:", "Una clase de la c�al se deriva otra clase", "Una clase que no necesita de nadie m�s.", "Una clase que agrupa objetos de diferentes clases", "Una clase derivada de otra clase y que la hace m�s fuerte" } },
      /*7*/   { new List<string>(){ "Una variable es:", "Un lugar para almacenar cualquier valor", "Un dato", "Un lugar para almacenar n�meros", "Ninguna de las anteriores" } },
      /*8*/   { new List<string>(){ "Es lo que se le puede hacer a un objeto:", "Operaciones","Atributos", "Plantillas", "M�todos" } },
      /*9*/   { new List<string>(){ "Es la plantilla para crear objetos", "Clase", "Objeto", "Plantilla", "Biblioteca" } },
      /*10*/  { new List<string>(){ "Las caracter�sticas fundamentales de la POO:", "Abstracci�n, encapsulamiento, herencia, poliformismo", "Ninguna de las anteriores", "M�todos y operaciones", "Objetos y clases." } },
      /*11*/  { new List<string>(){ "Que elementos crees que definen a un objeto:", "Sus atributos y sus m�todos", "Su forma en que establece comunicaci�n e intercambia mensajes", "Su cardinalidad y su tipo ", "Su interfaz y sus eventos asociados" } },
      /*12*/  { new List<string>(){ "Atributos (datos) y comportamiento (c�digo) est�n modularizados en una solaentidad, y hay diferentes niveles de protecci�n de los mismos", "Encapsulamiento", "Protecci�n", "Poliformismo", "Especializaci�n" } },
      /*13*/  { new List<string>(){ "�Que es la comunicaci�n entre objetos?", "Cuando se produce un evento, el objeto receptor sabe cual es el objeto emisor y el valor con los datos apropiados tengan el mismo evento", "La comunicaci�n de varias computadoras al programar", "Cuando 2 objetos se comunican", "Ninguna de las anteriores" } },
      /*14*/  { new List<string>(){ "�Que es la abstracci�n?", "Las caracter�sticas espec�ficas de un objeto, aquellas que lo distinguen de los dem�s tipos de objetos y que logran definir l�mites conceptuales respecto a quien est� haciendo dicha abstracci�n del objeto", "Es la caracter�stica que define una computadora", "Es una herramienta de programaci�n", "Ninguna de las anteriores" } },
      /*15*/  { new List<string>(){ "�Que es una herencia", "Es donde una clase nueva se crea a partie de una clase existente", "Es una herramienta de programaci�n", "El tipo de valor de una variable", "Ninguna de las anteriores" } },
      /*16*/  { new List<string>(){ "Una instancia de una clase es:", "Un objeto que pertenece a esta clase", "Una clase que es autom�tica", "Una clase que forma parte de un conjunto de clases", "Una referencia a una clase" } },
      /*17*/  { new List<string>(){ "�Que es el poliformismo?", "Es una relajaci�n del sistema de tipos, de t�l manera que una referencia a una clase, acepta direcciones de objetos de dicha clase y sus clases derivadas", "Es una variable en la programaci�n", "Es una base de la programaci�n", "Ninguna de las anteriores" } },
      /*18*/  { new List<string>(){"Cuando una acci�n (m�todo u operaci�n) es modificada por una clase derivada:", "Sobreescritura", "Generalizaci�n", "Sobrecarga", "Abstracci�n" } },
      /*19*/  { new List<string>(){ "Se refiere a caracter�sticas principalmente f�sicas y de estado de un objeto:", "Atributos", "M�todos", "Operaciones", "Objetos" } },
      /*20*/  { new List<string>(){ "�C�mo se diferencia la POO de la programaci�n estructurada tradicionalmente?", "Poo une los datos con el comportamiento que nos manipula", "Poo separa los datos del com�portamiento que los manipula", "No existe mayor diferencia m�s que en la forma en como se organizan las clases","Ninguna de las anteriores" } },
      /*21*/  { new List<string>(){ "Los m�todos en la programaci�n son:", "Los m�todos de instancia an�logamente a los procedimientos en lenguajes imperativos, un m�todo consiste generalmente de una serie de sentencias para llevar acabo una acci�n", "Un m�todo es que este �ltimo, al estar asociado con un objeto o clase en particular, puede acceder y modificar los datos privados del objeto", "Los m�todos de instancia an�logamente a los procedimientos en lenguajes imperativos, un m�todo consiste generalmente de una serie de sentencias para llevar acabo una acci�n", "Ninguna de las anteriores" } },
      /*23*/  { new List<string>(){ "Analiza e indica el resultado del siguiente c�digo ", "El c�digo presenta errores y no se puede ejecutar ", "El c�digo presenta errores y muestra: La suma es de: 30", "El c�digo no presenta errores y muestra: � La suma es: 20�", "Ninguna de las anteriores" } },
      /*24*/  { new List<string>(){ "�Que es el encapsulamiento?", "Es el proceso de almacenar en una misma secci�n, los elementos de una abstracci�n que constituye su estructura y su comportamiento", "Es la base primordial de la programaci�n", "Es un tipo de programa ", "Ninguna de las anteriores" } },
      /*25*/  { new List<string>(){ "La siguiente defici�n: �oculta los campos implementados en la clase, esto implica el tratamiento de los campos como una �nica unidad), corresponde a:", "Encapsulaci�n", " Poliformismo", "Herencia ", "Ninguna de las anteriores" } },
      /*26*/  { new List<string>(){ "�Que son los m�todos est�ticos?", "Son aquellos que no necesitan acceso a ning�n atributo de un objeto en concreto de la clase", "M�todos que no se mueves", "Contiene operaciones complejas", "Ninguna de las anteriores" } },
      /*27*/  { new List<string>(){ "Las variables comienzan con un (�) son consideradas variables privadas.", "Guion bajo", "Corchete", "Parentesis", "Ninguna de las anteriores" } },
      /*28*/  { new List<string>(){ "De los siguientes operadores c�al no es un operador l�gico", "<=", "!", "&&", "Todos son operadores l�gicos" } },
      /*29*/  { new List<string>(){ "La siguiente definici�n: "+"Describe la capacidad de crear clases nuevas a partir de una clase existente"+", corresponde a?", "Herencia", "Poliformismo", "Encapsulamiento", "Ninguna de las anteriores" } },
      
    };


    public void quitQuestion(int num)
    {
       
        questions.RemoveAt(num);

    }
}
