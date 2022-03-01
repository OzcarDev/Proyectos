using UnityEngine;
using System.Collections;

public class CambioEscena : MonoBehaviour {

	//Script para mandar llamar otra escena

	
	public void ChangeToScene(string sceneToChangeTo) {	//Método público para cambiar escena

		Application.LoadLevel (sceneToChangeTo);	//Aqui colocamos el nombre de la escena que invocaremos
													//desde las propiedades del Botón "On click"
	}
}
