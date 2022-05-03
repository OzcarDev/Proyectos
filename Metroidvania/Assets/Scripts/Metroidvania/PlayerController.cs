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
	
	[Header("For Attack")]
	public GameObject attackCollider;
	
	
	[Header("For Animation")]
	public Animator animation;
	public bool isAttacking;
	
	public int life;
	public bool isDamaged;
	public SpriteRenderer sprite;
    void Start()
    {
        
    }

    
    void Update()
    {
	    horizontal = Input.GetAxisRaw("Horizontal");
	    Jump();
	    if(Input.GetButtonDown("Fire1")){
		    
		    StartCoroutine(   Attack());
	    }
    }
    
	void FixedUpdate(){
		HorizontalMove();
	}
    
    
	IEnumerator Attack(){
	
		animation.Play("Attack");
		isAttacking = true;
		yield return new WaitForSeconds(0.1f);
		attackCollider.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		isAttacking = false;
		attackCollider.SetActive(false);
		}
    
	void Jump(){
		CheckGround();
		
		
		if(Input.GetButtonDown("Jump")||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
			
			jumpBufferCounter = jumpBufferLength;
		} else { jumpBufferCounter -= Time.deltaTime;}
		
		if((jumpBufferCounter>0&&coyoteTimeCounter>0)){
			rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
			jumpBufferCounter = 0;
			coyoteTimeCounter = 0;
			
			
		} 
		
		if((Input.GetButtonDown("Jump")||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))&&!grounded&&coyoteTimeCounter<0){
			if(doubleJump){
				rb.velocity = Vector2.zero;
				rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
				doubleJump = false;
				
			}
		
		
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
			if(!isAttacking){
				animation.Play("Jump");
			}
		}
	}
    
	void HorizontalMove(){
		
		
		
		if(horizontal < 0.0f)transform.localScale = new Vector3(-1.0f,1,1);
		else if(horizontal>0.0f)transform.localScale = new Vector3(1,1,1);
		
		rb.velocity = new Vector2(horizontal*speed,rb.velocity.y);
		
		if(horizontal == 0.0f&&grounded&&!isAttacking){
			animation.Play("Idle");
		} else if(horizontal!=0.0f&&grounded&&!isAttacking){
			animation.Play("Run");
		}
		
	}
	
	private void OnDrawGizmosSelected(){
		
		Gizmos.color = Color.red;
		Gizmos.DrawCube(groundCheckPoint.position,groundCheckSize);
	}
	
	public IEnumerator Dead(){
		
		Destroy(this.gameObject);
		yield return new WaitForSeconds(0.03f);
	}
	
	public IEnumerator Damage(){
		Color colorInicial= sprite.material.color;
		sprite.material.color = Color.red;
		isDamaged = true;
		yield return new WaitForSeconds(0.3f);
		isDamaged = false;
		sprite.material.color = colorInicial;
		
	} 
}
