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
    void FixedUpdate()
    {
	    if(GameGlobals.isAlive){ //verificar si el jugador sigue vivo 
		    if (Input.GetKey(KeyCode.Space)&& Grounded)//verificar el inout y si el jugador esta tocando el suelo 
        {
			    rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);//impulsar el rigidbody para saltar
        } }
        
    }
	private void OnCollisionEnter(Collision other)//checar si esta colisionando
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
