using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool state;
    int value;
    

 public void ButtonAction()
    {
        if (state)  {
            GameGlobals.totalTime += 5;
            GameGlobals.score += value;
        } else
        if (!state) {

            GameGlobals.totalTime -= 5;

        }

    }
}
