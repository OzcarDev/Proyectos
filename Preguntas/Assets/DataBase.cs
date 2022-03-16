using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataBase : MonoBehaviour
{
   
    public List<List<string>> questions = new List<List<string>>()
    {
      /*0*/   { new List<string>(){"0","1","2","3","4" } },
      /*1*/   { new List<string>(){"5","6","7","8","9" } },
      /*2*/   { new List<string>(){"10","11","12","13","14" } },
      /*3   { new List<string>(){"","","","","" } },
      /*4 { new List<string>(){"","","","","" } },
      /*5   { new List<string>(){"","","","","" } },
      /*6   { new List<string>(){"","","","","" } },
      /*7   { new List<string>(){"","","","","" } },
      /*8   { new List<string>(){"","","","","" } },
      /*9   { new List<string>(){"","","","","" } },
      /*10  { new List<string>(){"","","","","" } },
      /*11  { new List<string>(){"","","","","" } },
      /*12  { new List<string>(){"","","","","" } },
      /*13  { new List<string>(){"","","","","" } },
      /*14  { new List<string>(){"","","","","" } },
      /*15  { new List<string>(){"","","","","" } },
      /*16  { new List<string>(){"","","","","" } },
      /*17  { new List<string>(){"","","","","" } },
      /*18  { new List<string>(){"","","","","" } },
      /*19  { new List<string>(){"","","","","" } },
      /*20  { new List<string>(){"","","","","" } },
      /*21  { new List<string>(){"","","","","" } },
      /*23  { new List<string>(){"","","","","" } },
      /*24  { new List<string>(){"","","","","" } },
      /*25  { new List<string>(){"","","","","" } },
      /*26  { new List<string>(){"","","","","" } },
      /*27  { new List<string>(){"","","","","" } },
      /*28  { new List<string>(){"","","","","" } },
      /*29  { new List<string>(){"","","","","" } },*/
      
    };


    public void quitQuestion(int num)
    {
       
        questions.RemoveAt(num);

    }
}
