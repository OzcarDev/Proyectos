using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Platform : MonoBehaviour
{
	public int velocity;
	public bool state;
	
	void Update(){
		if(state){
			transform.Translate(Vector3.left*velocity*Time.deltaTime);
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Chocando");
		if(other.gameObject.tag == "PlatformDestroyer"){
			transform.position = new Vector3(-4,-8,0);
			state = false;
			
		}
	}
}
