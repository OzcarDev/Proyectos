using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPersonaje : MonoBehaviour
{
	
	public float force = 150;//fuerza de salto
    Rigidbody rb;
    private bool Grounded;
    // Start is called before the first frame update
    void Start()
	{
		force = GameGlobals.JumpForce;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
	    if(GameGlobals.isAlive){
		    if (Input.GetKey(KeyCode.Space)&& Grounded) 
        {
			    Jump();
        } }
        
    }
    
	private void Jump(){
		rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
	}
    
    
	private void OnCollisionEnter(Collision other)
    {
	    if (other.gameObject.tag == "Ground")
        {
		    Grounded = true;
        }
        
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Grounded = false;
        }
    }
}
