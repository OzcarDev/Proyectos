using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text score;
	public string scene;
	public string winScene;
	public int totalPoints;
    // Start is called before the first frame update
    void Start()
    {
	    RunerGameGlobals.gameState = true;
	    RunerGameGlobals.points = 0;
    }

    // Update is called once per frame
    void Update()
	{
		score.text = RunerGameGlobals.points.ToString();
    	
	    if(!RunerGameGlobals.gameState){
	    	
	    	
	    	SceneManager.LoadScene(scene);
	    }
	    
		if(RunerGameGlobals.points == totalPoints){
			
			SceneManager.LoadScene(winScene);
		}
    }
}
