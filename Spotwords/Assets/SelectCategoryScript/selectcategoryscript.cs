using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class selectcategoryscript : MonoBehaviour {

	public Button backmainmenu;
	public Button animalbutton;
	public Button objectbutton;
	public Button fruitsbutton;


	// Use this for initialization
	void Start () {
		backmainmenu = backmainmenu.GetComponent<Button> ();
		animalbutton = animalbutton.GetComponent<Button> ();
		fruitsbutton = fruitsbutton.GetComponent<Button> ();
	}

	// Update is called once per frame
	public void BackButton()
	{
		SceneManager.LoadScene ("GameMenu");
	}

	public void AnimalButton()
	{
		SceneManager.LoadScene ("AnimalLvl1");

	}
	public void ObjectButton()
	{
		SceneManager.LoadScene ("ObjectLvl1");
	}

	public void FruitButton()
	{
		SceneManager.LoadScene ("fruitlvl1");
	}
}