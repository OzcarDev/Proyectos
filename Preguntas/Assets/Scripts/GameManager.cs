using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public float totalTime;
    public Text counter;
	public string scene;
	public Animator carita;
    
    
    void Start()
    {
        GameGlobals.totalTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
       GameGlobals.totalTime -= Time.deltaTime;
        Countdown();
        if (!GameGlobals.gameState)
        {
            SceneManager.LoadScene(scene);
        }
        
	  
    }
    
	
		
		
		
	

    void Countdown()
    {

        if(GameGlobals.totalTime >= 0)
        {
            counter.text = (""+Mathf.Round(GameGlobals.totalTime));
        }

        if (GameGlobals.totalTime<= 0)
        {
            Debug.Log("Fin del juego");
            GameGlobals.gameState = false;
        }
    }

   
}
