using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerHandler_01 : MonoBehaviour {
	
	private bool inAir = false;

	private int _animState = Animator.StringToHash("animState");
	private Animator _animator;
	private GameObject Posicion;					//Variable de instanciamiento, Para obtener la posición del "Player" cuando cae
	public bool jumpPress = false;
	private float caida;										//variable para obtener los valores de caida del "Player"

	void Start () {
		_animator = this.transform.GetComponent<Animator> ();		//Instanciando "Animator",
		Posicion= GameObject.Find("Player");									//Instanciando al "Pleyer"
	
		

	}
	
	// Update is called once per frame
	void Update ()
	{

		if(!inAir && this.GetComponent<Rigidbody2D>().velocity.y > 0.05f)					//si esta en el aire...
		{
			
			_animator.SetInteger(_animState,1);																//cambia animación "Jump"
			inAir =true;

		}
		else if(inAir && this.GetComponent<Rigidbody2D>().velocity.y == 0.00f)			//si toca el piso....
		{
			//Debug.Log(inAir);
			_animator.SetInteger(_animState,0);																	//cambia animación "walk"
			inAir =false;
			if(jumpPress)jump ();
		}

		caida = Posicion.transform.position.y;									//Obtenemos los valores de la caida.
		if (caida < -10.0f)
        {
			SceneManager.LoadScene("EscenaFinal1nivel");                                                                            //reinicia nivel
		}
		//Debug.Log(caida);

	}


	public void jump(){
		jumpPress = true;
		if (inAir)return;
		//this.GetComponent<Rigidbody2D>().AddForce (Vector2.up * 3000);
		this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400);
		//GameObject.Find("Main Camera").GetComponent<playSound>().PlaySound("jump");
	}


}
