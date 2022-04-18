using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class developerscript : MonoBehaviour {

	public Button backbutton;

	// Use this for initialization
	void Start () {
		backbutton = backbutton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	public void BackButtonMenu()
	{
		SceneManager.LoadScene ("GameMenu");
	}
}
