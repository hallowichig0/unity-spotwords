using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class GravityFall11 : MonoBehaviour {

	public scorescript _scorescript;

	// Update is called once per frame
	void Update () {
		
		if (transform.position.y <= Time.deltaTime)
		{
			
			PlayerPrefs.SetInt("scoresession", _scorescript.scorecount);
			SceneManager.LoadScene ("GameOver3");
		}
	}	
}
