using UnityEngine;
using System.Collections;

public class inputController_01 : MonoBehaviour {

	//private bool isMobile = true;								//es un celular?? = verdadero		
	private playerHandler_01 _player;                   //variable de clase
	public GameObject SonidoJump;

	void Start () {
		//if (Application.isEditor)           //si la aplicación esta corriendo dentro de "Editor"
			
		//isMobile = false;									//usas celular = falso
		_player = GameObject.Find ("Player").GetComponent<playerHandler_01> ();	//instacía clase "playerHandler_06"
		
	}

	
	// Update is called once per frame
	void Update ()
	{

			if (Input.GetKeyDown(KeyCode.Space))            //Si se aprieta la baraaespaciadora..
		{
			Instantiate(SonidoJump);

			handleInteraction(true);							//ejecuta el método "handleInteraction"
			}
			//if(Input.GetMouseButtonUp(0))               //Si se suelta el botópn del Mouse ejecuta...
			if (Input.GetKeyUp(KeyCode.Space))           //Si se suelta la baraaespaciadora..
		{
				handleInteraction(false);
			}
	
	}


	void handleInteraction(bool starting){

		if (starting)
		{
			_player.jump();
		}
		else
		{
			_player.jumpPress=false;
		}

	}

}
