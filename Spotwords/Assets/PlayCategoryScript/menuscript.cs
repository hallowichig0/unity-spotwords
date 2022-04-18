using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuscript : MonoBehaviour {

	public Canvas quitmenu;
	public Button playtext;
	public Button scorebutton;
	public Button developerbutton;
	public Button instructionbutton;
	public Button exittext;

	// Use this for initialization
	void Start () {
		quitmenu = quitmenu.GetComponent<Canvas> ();
		playtext = playtext.GetComponent<Button> ();
		scorebutton = scorebutton.GetComponent<Button> ();
		developerbutton = developerbutton.GetComponent<Button> ();
		instructionbutton = instructionbutton.GetComponent<Button> ();
		exittext = exittext.GetComponent<Button> ();
		quitmenu.enabled = false;
	}

	public void ExitPress()
	{
		quitmenu.enabled = true;
		playtext.enabled = false;
		developerbutton.enabled = false;
		exittext.enabled = false;
	}

	public void NoPress()
	{
		quitmenu.enabled = false;
		developerbutton.enabled = true;
		playtext.enabled = true;
		exittext.enabled = true;
	}

	// Update is called once per frame
	public void StartLevel()
	{
		SceneManager.LoadScene ("PlayCategory");
	}

	public void ScoreButtonLevel()
	{
		SceneManager.LoadScene ("Score");
	}

	public void DeveloperButtonLevel()
	{
		SceneManager.LoadScene ("Developer");
	}

	public void InstructionButtonLevel()
	{
		SceneManager.LoadScene ("Instruction");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
