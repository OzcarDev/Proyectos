using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
	
	public GameObject gameOver;
	public GameObject winScreen;
 
    void Update()
    {
	    GameOver();
	    
	    Win();
    }
    
	private void GameOver(){
		if(!GameGlobals.isAlive ){
			gameOver.SetActive(true);
	    	
	    	
		} else if(GameGlobals.isAlive){
			gameOver.SetActive(false);
		}
	}
	
	private void Win(){
		if(GameGlobals.win){
			winScreen.SetActive(true);
	    	
		} else if(!GameGlobals.win){
			winScreen.SetActive(false);
		}
	}
}
