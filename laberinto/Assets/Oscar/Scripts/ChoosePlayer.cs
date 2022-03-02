using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayer : MonoBehaviour
{
	public float newVelocity;
	public float newForce;
	
	public void Spects(){
		GameGlobals.Velocity = newVelocity;
		GameGlobals.JumpForce = newForce; 
		
		
	}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
