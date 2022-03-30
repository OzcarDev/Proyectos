using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	[Header("For Movement")]
	public float speed;
	private float horizontal;
	public Rigidbody2D rb;
	
	[Header("For Jump")]
	public float jumpForce;
	public float newGravityScale;
	public float gravityScale;
	[SerializeField] LayerMask capaSuelo;
	private bool doubleJump;
	private bool grounded;
	public float coyoteTime;
	private float coyoteTimeCounter;
	public float jumpBufferLength;
	private float jumpBufferCounter;
	public Transform groundCheckPoint;
	[SerializeField] Vector2 groundCheckSize;
	
    
    void Start()
    {
        
    }

    
    void Update()
    {
	    horizontal = Input.GetAxisRaw("Horizontal");
	    Jump();
    }
    
	void FixedUpdate(){
		HorizontalMove();
	}
    
    
	void Jump(){
		CheckGround();
		
		
		if(Input.GetButtonDown("Jump")||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
			
			jumpBufferCounter = jumpBufferLength;
		} else { jumpBufferCounter -= Time.deltaTime;}
		
		if(jumpBufferCounter>0&&coyoteTimeCounter>0){
			rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
			jumpBufferCounter = 0;
			coyoteTimeCounter = 0;
			
		}
		
		if((Input.GetButtonUp("Jump")|| Input.GetKeyUp(KeyCode.W))&& rb.velocity.y > 0)
		{   
			//Reiniciar velocidad
			rb.velocity = Vector2.zero;
			//Asignar velocidad nuevamente al jugador
			rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
		}
		
		
	}
	
	void CheckGround(){
		grounded = Physics2D.OverlapBox(groundCheckPoint.position,groundCheckSize,0,capaSuelo);
		
		if(grounded){
			coyoteTimeCounter = coyoteTime;
			doubleJump = true;
		} 
		else if(!grounded){
			coyoteTimeCounter -= Time.deltaTime;
			
		}
	}
    
	void HorizontalMove(){
		
		
		
		if(horizontal < 0.0f)transform.localScale = new Vector3(-1.0f,1,1);
		else if(horizontal>0.0f)transform.localScale = new Vector3(1,1,1);
		
		rb.velocity = new Vector2(horizontal*speed,rb.velocity.y);
		
	}
	
	private void OnDrawGizmosSelected(){
		
		Gizmos.color = Color.red;
		Gizmos.DrawCube(groundCheckPoint.position,groundCheckSize);
	}
}
