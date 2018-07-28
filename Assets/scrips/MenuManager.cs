using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour {

	//use these for instansiate
	public void MenuScene()
	{
		SceneManager.LoadScene ("scenes");
	}

}