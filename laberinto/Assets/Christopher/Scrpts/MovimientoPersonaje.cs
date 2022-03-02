using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float force=150;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
	    if(GameGlobals.isAlive){
        transform.Translate(h * force * Time.deltaTime, 0, 0);
		    transform.Translate(0,0, v * force * Time.deltaTime);
	    }


    }
}
