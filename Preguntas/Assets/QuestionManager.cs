using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManager : MonoBehaviour
{
    int randomNum;
    public int totalTime;
    DataBase question = new DataBase();
    public Text textField;
    public Text button0;
    public Text button1;
    public Text button2;
    public Text button3;

    List<Transform> positions = new List<Transform>();
    public Transform[] tbuttons = new Transform[4];
  

    private void Start()
    {
        GameGlobals.gameState = true;
        GameGlobals.totalTime = totalTime;
        GameGlobals.score = 0;
        QuestionDrawer();
        positions = new List<Transform>{
            tbuttons[0],tbuttons[1],tbuttons[2],tbuttons[3]

        };
    }

    public void QuestionDrawer()

    {
        randomizeButtons();
        randomNum = Random.Range(0, question.questions.Count);
        textField.text = question.questions[randomNum][0];
        button0.text = question.questions[randomNum][1];
        button1.text = question.questions[randomNum][2];
        button2.text = question.questions[randomNum][3];
        button3.text = question.questions[randomNum][4];
        question.quitQuestion(randomNum);
        

    }

    public void randomizeButtons()
    {
        for(int i= 0;i<= 4; i++)
        {
            int randomPosition = Random.Range(0,positions.Count);
            tbuttons[i] = positions[randomPosition];
            positions.RemoveAt(randomPosition);
        }
        positions = new List<Transform>{
            tbuttons[0],tbuttons[1],tbuttons[2],tbuttons[3]

        };


    }
}
