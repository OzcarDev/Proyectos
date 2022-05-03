using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
	public PlayerController pc;
	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Enemy"&&!pc.isDamaged){
			
			pc.life--;		
			StartCoroutine(pc.Damage());
			if(pc.life<=0)StartCoroutine(pc.Dead());
			Debug.Log(pc.life);
		}	
	}
}
