using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoader : MonoBehaviour
{
	public GameObject[] enemy;
	int coinNum;
	Coin coinState;
	// Start is called before the first frame update
	void Start()
	{
		enemy = new GameObject[21];
		for(int i = 0; i<= 20; i++){
			enemy[i] = GameObject.Find("Spikes ("+i+")");
	    	
	    	
		}
		InvokeRepeating("coinPosition",Random.Range(4f,6f),Random.Range(5f,12f));
        
	}

	void coinSelection(){
		
		coinNum = Random.Range(0,20);
		
	}
	
	void coinPosition(){
		
		do{
			coinSelection();
			coinState = enemy[coinNum].GetComponent<Coin>();
		}while(coinState.state);
		
		coinState.state = true;
		enemy[coinNum].transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
		
	}
}
