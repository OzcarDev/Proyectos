using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManager : MonoBehaviour
{
    int randomNum;
    int randomPosition;

 
    DataBase question = new DataBase();
    public Text textField;
    public Text button0;
    public Text button1;
    public Text button2;
    public Text button3;

    
    public RectTransform[] tbuttons = new RectTransform[4];
    public List<RectTransform> positions = new List<RectTransform>();


    private void Start()
    {
        GameGlobals.gameState = true;
      
        GameGlobals.score = 0;
        QuestionDrawer();
    
    }

   

    public void QuestionDrawer()

    {
        if (question.questions.Count > 0)
        {

            RandomizeButtons();
            randomNum = Random.Range(0, question.questions.Count);
            textField.text = question.questions[randomNum][0];
            button0.text = question.questions[randomNum][1];
            button1.text = question.questions[randomNum][2];
            button2.text = question.questions[randomNum][3];
            button3.text = question.questions[randomNum][4];
            question.quitQuestion(randomNum);
        }

        else if(question.questions.Count<=0)
        {
            GameGlobals.gameState = false;
            Debug.Log("Fin del juego");

        }
        

    }

    public void RandomizeButtons()
    {
         for (int i = 0; i<=3;i++) {
        randomPosition = Random.Range(0, positions.Count);
       


            tbuttons[i].anchoredPosition = positions[randomPosition].anchoredPosition;
               

             
           positions.RemoveAt(randomPosition);
         }

         for(int i = 0; i<=3; i++)
        {
            positions.Add(GameObject.Find("Pivote ("+i+")").GetComponent<RectTransform>());

        }

     }


}
