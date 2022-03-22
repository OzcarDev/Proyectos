using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public bool state;
    int value = 1;
	public Text Score;
	public Animator animation;
	public Animator bonusAnimation;

    private void Start()
    {
        Score = GameObject.Find("Score").GetComponent<Text>();
       
    }
    public void ButtonAction()
    {
        if (state)  {
	        GameGlobals.totalTime += 7;
            GameGlobals.score += value;
	        Score.text = GameGlobals.score.ToString();
	        animation.Play("Correcto");
	        bonusAnimation.Play("Bonus");
        } else
        if (!state) {

            GameGlobals.totalTime -= 5;
	        Debug.Log("Menos");
	        animation.Play("Incorrecto");
	        bonusAnimation.Play("Bonus");

        }

    }
}
