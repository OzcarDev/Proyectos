using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInteract : MonoBehaviour
{
	GameObject objeto;
	bool isTouchingWall;
    // Start is called before the first frame update
    void Start()
    {

    }
	private void OnTriggerEnter(Collider other)
    {

	    if (other.gameObject.tag == "Obstacle")//revisando si el personaje esta tocando un objeto
        {
		    isTouchingWall= true;
		    objeto = other.gameObject;
           
        }


    }
    
	private void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Obstacle")
		{
			isTouchingWall = false;
			objeto = null;
           
		}
	}
    
	void Update(){
		if ( isTouchingWall &&(Input.GetKey(KeyCode.H)))
		{
			Destroy(objeto);
           
		}
	}
     
}
