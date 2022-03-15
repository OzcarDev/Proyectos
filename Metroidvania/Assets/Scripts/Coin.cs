using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	public int value;
	public int velocity;
	public bool state;
    

    void Update()
    {
	    if(state){
	    	
	    	transform.Translate(Vector3.left*velocity*Time.deltaTime);
	    } 
    }
    
	void OnTriggerEnter2D (Collider2D other){
		if(other.gameObject.tag == "PlatformDestroyer"){
			
			transform.position = new Vector3(-4,-8,0);
			state = false;
		}
		
		if(other.gameObject.tag == "Player"){
			
			RunerGameGlobals.points += value;
			transform.position = new Vector3(-4,-8,0);
			state = false;
		}
		
		
	}
    
}
