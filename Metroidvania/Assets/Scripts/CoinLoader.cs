using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLoader : MonoBehaviour
{
	
	public GameObject[] coins;
	int coinNum;
	Coin coinState;
    // Start is called before the first frame update
    void Start()
    {
	    coins = new GameObject[21];
	    for(int i = 0; i<= 20; i++){
	    	coins[i] = GameObject.Find("Coin ("+i+")");
	    	
	    	
	    }
	    InvokeRepeating("coinPosition",Random.Range(1f,4f),Random.Range(3f,8f));
        
    }

	void coinSelection(){
		
		coinNum = Random.Range(0,20);
		
	}
	
	void coinPosition(){
		
		do{
			coinSelection();
			coinState = coins[coinNum].GetComponent<Coin>();
		}while(coinState.state);
		
		coinState.state = true;
		coins[coinNum].transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
		
	}
}
