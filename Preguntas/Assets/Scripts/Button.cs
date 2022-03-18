using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public bool state;
    int value = 1;
    public Text Score;

    private void Start()
    {
        Score = GameObject.Find("Score").GetComponent<Text>();
       
    }
    public void ButtonAction()
    {
        if (state)  {
            GameGlobals.totalTime += 5;
            GameGlobals.score += value;
            Score.text = GameGlobals.score.ToString();
        } else
        if (!state) {

            GameGlobals.totalTime -= 5;
            Debug.Log("Menos");

        }

    }
}
