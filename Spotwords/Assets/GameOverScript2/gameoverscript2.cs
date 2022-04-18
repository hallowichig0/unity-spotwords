﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameoverscript2 : MonoBehaviour {

	public Button TryAgain;
	public Button BackToMain;
	public scorescript _scorescript;

	// Use this for initialization
	void Start () {
		BackToMain = BackToMain.GetComponent <Button> ();
	}

	public void TryAgainButton()
	{
		SceneManager.LoadScene ("ObjectLvl1");
	}

	public void BackMenuButton()
	{
		SceneManager.LoadScene ("GameMenu");
	}

	void Update()
	{
		if (_scorescript.scorecount >= _scorescript.hiscorecount) {

			SceneManager.LoadScene ("TopScore2");
		}
	}
	
	// Update is called once per frame

}
