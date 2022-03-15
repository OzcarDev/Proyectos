using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody2D rb;
	public float fuerza;


	

	void Update()
	{
		Salto();
	}

	public void Salto()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
		}
	}
}
