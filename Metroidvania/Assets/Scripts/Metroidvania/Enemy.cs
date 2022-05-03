using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	
	public int life;
	bool isDamaged;
	public SpriteRenderer sprite;


	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Attack"&&!isDamaged){
			
			life--;		
			StartCoroutine(Damage());
			if(life<=0)StartCoroutine(Dead());
			Debug.Log(life);
		}	
	}
	
	private IEnumerator Dead(){
		
		Destroy(this.gameObject);
		yield return new WaitForSeconds(0.03f);
	}
	
	
	private IEnumerator Damage(){
		Color colorInicial= sprite.material.color;
		sprite.material.color = Color.red;
		isDamaged = true;
		yield return new WaitForSeconds(0.3f);
		isDamaged = false;
		sprite.material.color = colorInicial;
		
	} 
}
