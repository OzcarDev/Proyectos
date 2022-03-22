using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody2D rb;
	public float fuerza;
	public int velocidad;
	bool isGrounded;
	[SerializeField] LayerMask capaSuelo;
	public Transform groundCheckPoint;
	[SerializeField] Vector2 groundCheckSize;
	float horizontal;
	public Animator Animation;
	public AudioSource audio;
	
	void Update()
	{
		Salto();
		Debug.Log(isGrounded);
		CheckGround();
		Movimiento();
		Animation.SetBool("Grounded",isGrounded);
		
	}
	
	void Movimiento(){
		horizontal = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right*horizontal*velocidad*Time.deltaTime);
		
	}

	public void Salto()
	{
		if (Input.GetKeyDown(KeyCode.Space)&&isGrounded)
		{
			rb.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
			audio.Play();
		}
	}
	
	void CheckGround(){
		
		isGrounded = Physics2D.OverlapBox(groundCheckPoint.position,groundCheckSize,0,capaSuelo);
		
		
	}
	private void OnDrawGizmosSelected(){
	
		Gizmos.color = Color.red;
		Gizmos.DrawCube(groundCheckPoint.position,groundCheckSize);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Enemy"){
			
			RunerGameGlobals.gameState = false;
			
		}
		
		
	}
	
}
