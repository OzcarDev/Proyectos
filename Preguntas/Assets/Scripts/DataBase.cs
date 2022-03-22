using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataBase : MonoBehaviour
{
   
    public List<List<string>> questions = new List<List<string>>()
    {
	    /*0*/   { new List<string>(){ "¿Que es la programacion orientada a objetos?", "Es una forma especial de programar, más cercana a como expresariamos las cosas en la vida real que otros tipos de programación.", "Programación de celulares con objetos", "Es una forma de programar con objetos reales", "-Ninguna de las anteriores","0" } },
	    /*1*/   { new List<string>(){ "Caracteristicas de la programación orientada a objetos:", "Abstracción, encapsulamiento, principio de ocultación, herencia y poliformia", "Objeto, programa y máquina", "Atracción, repulsión, imán ", "Herencia, programa, atracción", "0"} },
	    /*2*/   { new List<string>(){ "¿Que es una subclase?", "La clase que proviene de otras clases ", "Es una variable", "Ninguna de las anteriores", "Tipo de programa en visual", "0" } },
	    /*3*/   { new List<string>(){ "¿Que tipo de clases puedo hacer en java?", "P�blicas y privadas", "Públicas y módulos", "Modulos", "Privadas", "0" } },
	    /*4*/   { new List<string>(){ "El comportamiento de un objeto son:", "Operaciones y métodos", "Atributos físicos", "Atributos abstractos", "Ninguna de las anteriores", "0" } },
	    /*5*/   { new List<string>(){"Dentro de un conjunto de objetos existen diferentes formas y maneras de hacer las cosas", "Poliformismo", "Generalización", "Herencia", "Abstracción", "0" } },
	    /*6*/   { new List<string>(){ "Una superclase es:", "Una clase de la cúal se deriva otra clase", "Una clase que no necesita de nadie más.", "Una clase que agrupa objetos de diferentes clases", "Una clase derivada de otra clase y que la hace más fuerte", "0" } },
	    /*7*/   { new List<string>(){ "Una variable es:", "Un lugar para almacenar cualquier valor", "Un dato", "Un lugar para almacenar números", "Ninguna de las anteriores", "0" } },
	    /*8*/   { new List<string>(){ "Es lo que se le puede hacer a un objeto:", "Operaciones","Atributos", "Plantillas", "Métodos", "0" } },
      /*9*/   { new List<string>(){ "Es la plantilla para crear objetos", "Clase", "Objeto", "Plantilla", "Biblioteca", "0" } },
      /*10*/  { new List<string>(){ "Las características fundamentales de la POO:", "Abstracción, encapsulamiento, herencia, poliformismo", "Ninguna de las anteriores", "Métodos y operaciones", "Objetos y clases.", "1" } },
      /*11*/  { new List<string>(){ "Que elementos crees que definen a un objeto:", "Sus atributos y sus métodos", "Su forma en que establece comunicación e intercambia mensajes", "Su cardinalidad y su tipo ", "Su interfaz y sus eventos asociados", "1" } },
      /*12*/  { new List<string>(){ "Atributos (datos) y comportamiento (código) están modularizados en una solaentidad, y hay diferentes niveles de protección de los mismos", "Encapsulamiento", "Protección", "Poliformismo", "Especialización", "1" } },
      /*13*/  { new List<string>(){ "¿Que es la comunicación entre objetos?", "Cuando se produce un evento, el objeto receptor sabe cual es el objeto emisor y el valor con los datos apropiados tengan el mismo evento", "La comunicación de varias computadoras al programar", "Cuando 2 objetos se comunican", "Ninguna de las anteriores", "1" } },
      /*14*/  { new List<string>(){ "¿Que es la abstracción?", "Las características específicas de un objeto, aquellas que lo distinguen de los demás tipos de objetos y que logran definir límites conceptuales respecto a quien está haciendo dicha abstracción del objeto", "Es la característica que define una computadora", "Es una herramienta de programación", "Ninguna de las anteriores", "1" } },
      /*15*/  { new List<string>(){ "¿Que es una herencia", "Es donde una clase nueva se crea a partie de una clase existente", "Es una herramienta de programación", "El tipo de valor de una variable", "Ninguna de las anteriores", "1" } },
      /*16*/  { new List<string>(){ "Una instancia de una clase es:", "Un objeto que pertenece a esta clase", "Una clase que es automática", "Una clase que forma parte de un conjunto de clases", "Una referencia a una clase", "1" } },
      /*17*/  { new List<string>(){ "¿Que es el poliformismo?", "Es una relajación del sistema de tipos, de tál manera que una referencia a una clase, acepta direcciones de objetos de dicha clase y sus clases derivadas", "Es una variable en la programación", "Es una base de la programación", "Ninguna de las anteriores", "1" } },
      /*18*/  { new List<string>(){"Cuando una acción (método u operación) es modificada por una clase derivada:", "Sobreescritura", "Generalización", "Sobrecarga", "Abstracción" } },
      /*19*/  { new List<string>(){ "Se refiere a características principalmente físicas y de estado de un objeto:", "Atributos", "Métodos", "Operaciones", "Objetos", "2" } },
      /*20*/  { new List<string>(){ "¿Cómo se diferencia la POO de la programación estructurada tradicionalmente?", "Poo une los datos con el comportamiento que nos manipula", "Poo separa los datos del comportamiento que los manipula", "No existe mayor diferencia más que en la forma en como se organizan las clases","Ninguna de las anteriores", "2" } },
      /*21*/  { new List<string>(){ "Los métodos en la programación son:", "Los métodos de instancia análogamente a los procedimientos en lenguajes imperativos, un método consiste generalmente de una serie de sentencias para llevar acabo una acci�n", "Un método es que este último, al estar asociado con un objeto o clase en particular, puede acceder y modificar los datos privados del objeto", "Los métodos de instancia análogamente a los procedimientos en lenguajes imperativos, un m�todo consiste generalmente de una serie de sentencias para llevar acabo una acción", "Ninguna de las anteriores", "2" } },
	    /*23*///  { new List<string>(){ "Analiza e indica el resultado del siguiente código ", "El código presenta errores y no se puede ejecutar ", "El código presenta errores y muestra: La suma es de: 30", "El código no presenta errores y muestra: ¿La suma es: 20?", "Ninguna de las anteriores", "2" } },
      /*24*/  { new List<string>(){ "¿Que es el encapsulamiento?", "Es el proceso de almacenar en una misma sección, los elementos de una abstracción que constituye su estructura y su comportamiento", "Es la base primordial de la programación", "Es un tipo de programa ", "Ninguna de las anteriores", "2" } },
      /*25*/  { new List<string>(){ "La siguiente defición: ¿oculta los campos implementados en la clase, esto implica el tratamiento de los campos como una �nica unidad), corresponde a:", "Encapsulaci�n", " Poliformismo", "Herencia ", "Ninguna de las anteriores", "2" } },
      /*26*/  { new List<string>(){ "¿Que son los métodos estáticos?", "Son aquellos que no necesitan acceso a ningún atributo de un objeto en concreto de la clase", "Métodos que no se mueves", "Contiene operaciones complejas", "Ninguna de las anteriores", "2" } },
      /*27*/  { new List<string>(){ "Las variables comienzan con un (?) son consideradas variables privadas.", "Guion bajo", "Corchete", "Parentesis", "Ninguna de las anteriores", "2" } },
      /*28*/  { new List<string>(){ "De los siguientes operadores cúal no es un operador lógico", "<=", "!", "&&", "Todos son operadores lógicos", "2" } },
      /*29*/  { new List<string>(){ "La siguiente definición: "+"Describe la capacidad de crear clases nuevas a partir de una clase existente"+", corresponde a?", "Herencia", "Poliformismo", "Encapsulamiento", "Ninguna de las anteriores", "2" } },
      
    };


    public void quitQuestion(int num)
    {
       
        questions.RemoveAt(num);

    }
}
