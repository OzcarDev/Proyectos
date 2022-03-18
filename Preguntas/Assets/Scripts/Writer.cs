using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Writer : MonoBehaviour
{
    public Text score;
    void Start()
    {
        Debug.Log(GameGlobals.score);
        score.text = GameGlobals.score.ToString(); 
    }

   
}
