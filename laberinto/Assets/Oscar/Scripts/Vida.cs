using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
	
	public Text lifeCounter;
	public Text timeCounter;
	public float totalTime;
    // Start is called before the first frame update
    void Start()
    {
	    GameGlobals.isAlive = true;
	    GameGlobals.win = false; 
	    GameGlobals.vida = 5;
    }

    // Update is called once per frame
	void Update()
    
	{
		Timer();
		LifeCounter();
		
	}
    
	private void LifeCounter(){
		
		if(GameGlobals.vida<=0){
			GameGlobals.isAlive= false;
		}
		
		if(totalTime<=0&&!GameGlobals.win){
			GameGlobals.isAlive =false;
		}
		
		
	    
		lifeCounter.text = ("Vida: "+GameGlobals.vida);
	}
    
    
	private void Timer(){
		
		if(totalTime>0) totalTime -= 1*Time.deltaTime;
		
		
		timeCounter.text = ("Tiempo: "+ Mathf.Round(totalTime));
	}
	
	
	
	 void OnTriggerEnter(Collider other){
		 
		 if(GameGlobals.isAlive){
		 	if(other.gameObject.tag == "Goal"){
		 		GameGlobals.win = true;
		 	}
		 	
		if(other.gameObject.tag == "Enemy"){
			
			GameGlobals.vida = GameGlobals.vida-1;
		}}
		
	 }
}