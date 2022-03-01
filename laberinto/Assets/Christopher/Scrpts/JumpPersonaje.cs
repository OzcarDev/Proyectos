using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPersonaje : MonoBehaviour
{
    public float force = 150;
    Rigidbody rb;
    private bool Grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Space)&& Grounded)
        {
            rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
        }
        
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
