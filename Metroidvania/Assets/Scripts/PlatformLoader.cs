using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLoader : MonoBehaviour
{
	public GameObject[] Platforms;
	int platformNum;
	Platform platformState;
    // Start is called before the first frame update
    void Start()
	{
		Platforms = new GameObject[21];
	    for(int i = 0; i<=20; i++){
	    	Platforms[i] = GameObject.Find("Platform"+i);
	    	
	    	
	    }
	    
		InvokeRepeating("PlatformPosition",Random.Range(1f,4f),Random.Range(3f,8f));
    }

	
    
	void PlatformSelection(){
		
		platformNum = Random.Range(0,20);
	}
	
	void PlatformPosition(){
		do{
		PlatformSelection();
			platformState = Platforms[platformNum].GetComponent<Platform>();
		}while(platformState.state);


		platformState.state = true;
		Platforms[platformNum].transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z);
		
	}
}
