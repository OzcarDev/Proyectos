﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
	
	public GameObject gameOver;
	public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(!GameGlobals.isAlive ){
	    	gameOver.SetActive(true);
	    	
	    	
	    } else if(GameGlobals.isAlive){
	    	gameOver.SetActive(false);
	    }
	    
	    if(GameGlobals.win){
	    	winScreen.SetActive(true);
	    	
	    } else if(!GameGlobals.win){
	    	winScreen.SetActive(false);
	    }
    }
}
