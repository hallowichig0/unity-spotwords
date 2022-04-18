﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameoverscript : MonoBehaviour {

	public Button TryAgain;
	public Button BackToMain;
	public scorescript _scorescript;


	// Use this for initialization
	void Start () {
		BackToMain = BackToMain.GetComponent <Button> ();


	}

	public void TryAgainButton()
	{
		SceneManager.LoadScene ("AnimalLvl1");
	}

	public void BackMenuButton()
	{
		SceneManager.LoadScene ("GameMenu");
	}
	
	// Update is called once per frame
	void Update()
	{
		if (_scorescript.scorecount >= _scorescript.hiscorecount) {
			
			SceneManager.LoadScene ("TopScore");
		}
	}
}
