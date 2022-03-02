using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
	public float force=150;//velocidad en la que se mueve el personaje
    Rigidbody rb;
    void Start()
	{
		force = GameGlobals.Velocity;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
	    float h = Input.GetAxis("Horizontal");// se manda a llamar el input
	    float v = Input.GetAxis("Vertical");// se manda a llamar input vertical 
	    if(GameGlobals.isAlive){
		    transform.Translate(h * force * Time.deltaTime, 0, 0);// se le asigan un vector para que se traslade horizontalmente 
		    transform.Translate(0,0, v * force * Time.deltaTime);//se asignan un vector para que se trsalade verticalmente 
	    }


    }
}
