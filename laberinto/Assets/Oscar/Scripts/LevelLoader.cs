using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	public string Level;

	public void LoadScene(){
		SceneManager.LoadScene(Level);
	}
}
