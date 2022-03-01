using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class enemyScript : MonoBehaviour
{
	public GameObject SonidoEnemy;		//*

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll)						//para detectar penetración de colliders		
	{
		
		if (coll.gameObject.tag =="Player")                            //si se detecta una penetración de colliders de un objeto "tageado" el "Player"...
		{
			

			GameObject tmpPlayer = GameObject.Find("Player");		//crea una variable temporal tipo GameObject y nombrala="tmpPlayer"

			//tmpPlayer.GetComponent<Rigidbody2D>().AddForce(Vector2.right*200);
			//tmpPlayer.GetComponent<Rigidbody2D>().AddForce(Vector2.up*200);
			tmpPlayer.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;	//deshabilita el constraint
			tmpPlayer.GetComponent<Rigidbody2D>().transform.Rotate(new Vector3(0, 0, 70));          //rotar en "Z" 70º
																									//GameObject.Find("Main Camera").GetComponent<playSound>().PlaySound("die");
			Instantiate(SonidoEnemy);
			SceneManager.LoadScene("EscenaFinal1nivel");																			//reinicia nivel
			tmpPlayer.GetComponent<Collider2D>().enabled =false;
			
			
			

			//GameObject.Find("Main Camera").GetComponent<playSound>().PlaySound("die");

		}


	}

}
