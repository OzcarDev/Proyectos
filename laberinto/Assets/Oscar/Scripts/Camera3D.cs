using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3D : MonoBehaviour
{
	
	public Vector2 sensibility;
	private Transform camera;

	
    // Start is called before the first frame update
    void Start()
	{
    	
		camera = transform.Find("Main Camera");
	    Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
	{
    	
		
	    float hor = Input.GetAxis("Mouse X");
		float ver = Input.GetAxis("Mouse Y");
	    
	    if(GameGlobals.isAlive){
	    if(hor != 0){
	    	transform.Rotate(Vector3.up * hor*sensibility.x);
	    	
	    }
	    
	    if(ver != 0){
	    	camera.Rotate(Vector3.left*ver*sensibility.y);
	    } 
	    } 
	    
		if(!GameGlobals.isAlive||GameGlobals.win) {
	    	Debug.Log("DesbloqueandoCursor");
	    	Cursor.lockState = CursorLockMode.None;
	    }
	}
    
    
}
