//Script para generar las monedas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createScript : MonoBehaviour
{

	private float maxY;
	private float minY;
	private int direction = 1;

	public bool inPlay = true;
	private bool releaseCrate = false;


	private SpriteRenderer crateRender;

	private levelCreator_01 Nivel_10;
	public int coinValue;														//en inspector pone el valor de monedas a desplegar=40
	public GameObject SonidoMoneda;

	// Use this for initialization
	void Start()
	{

		maxY = this.transform.position.y + .5f;									//altura máxima del box al subir y bajar
		minY = maxY - 1.0f;                                                     //altura mínima del box al subir y bajar


		crateRender = this.transform.GetComponent<SpriteRenderer>();
		Nivel_10 = FindObjectOfType<levelCreator_01>();
	}

	// Update is called once per frame
	void Update()
	{

		this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + (direction * 0.05f));  //Velocidad del sube y baja del box
		if (this.transform.position.y > maxY)
			direction = -1;
		if (this.transform.position.y < minY)
			direction = 1;
		
		Debug.Log("releaseCrate "+releaseCrate);
		Debug.Log("inPlay " + inPlay);

		if (!inPlay && !releaseCrate)               // inPlay=false y !inPlay = true  y releaseCrate = false !releaseCrate = true..
		{
			Debug.Log("!releaseCrate " + !releaseCrate);
			Debug.Log("!inPlay " + !inPlay);
			respawn();
		}
	}

	void OnTriggerEnter2D(Collider2D coll)					//Al tocar la momeda con el Player...no la destruye la manda hasta arriba
	{
		Debug.Log("HaceContacto");
		if (coll.gameObject.tag == "Player")				//Si el que toca la moneda es el Player...
		{   
			Nivel_10.AddCoins(coinValue);					//Entra a "LavelCreator_01" al método "AddConits" y manda el valor = 40

			//inPlay = true;

			this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 30.0f);
			Instantiate(SonidoMoneda);

			//GameObject.Find("Main Camera").GetComponent<playSound>().PlaySound("power");
		}


	}

	void respawn()
	{

		releaseCrate = true;
		Invoke("placeCrate", (float)Random.Range(0, 0));            //Rango de spawn de los boxes
	}                                                                                                           //funsion que invoca el método "placeCrate" cada Random.Range"

	void placeCrate()						//Calacula donde  aparecer y a que altura las monedas..
	{

		inPlay = true;																					//Activa Spawner de monedas
		releaseCrate = false;

		GameObject tmpTile = GameObject.Find("Main Camera").GetComponent<levelCreator_01>().tilePos;  //Coloca en "tmpTile" el valor de "tilePos"=right,middle o left
		//Debug.Log(tmpTile);
		this.transform.position = new Vector2(tmpTile.transform.position.x, tmpTile.transform.position.y + 5.5f); //Coloca el box a esta altura del "tilePos"+5.5 en "Y"
		maxY = this.transform.position.y + .5f;								//Recalcula el sube y baja del Box
		minY = maxY - 1.0f;                                                 //Recalcula el sube y baja del Box


	}











}