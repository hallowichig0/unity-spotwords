using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class destroyObj6d : MonoBehaviour {


	// Variable for Gravity Fall
	public Canvas ThisCanvasObj;
	public Button Obj1;
	public Rigidbody GravityOff;

	// Variable for Slot
	public Canvas BoxSlot;
	public Canvas BoxSlot2;
	public Canvas BoxSlot3;

	// Variable for ScoreSystem
	public scorescript _scorescript;

	// Use this for initialization
	void Start () {
		Obj1 = Obj1.GetComponent<Button> ();
		ThisCanvasObj = ThisCanvasObj.GetComponent <Canvas> ();
		GravityOff = GravityOff.GetComponent <Rigidbody> ();
		BoxSlot = BoxSlot.GetComponent <Canvas> ();
		BoxSlot2 = BoxSlot2.GetComponent <Canvas> ();
		BoxSlot3 = BoxSlot3.GetComponent <Canvas> ();
		BoxSlot.enabled = false;
		BoxSlot2.enabled = false;
		BoxSlot3.enabled = false;

		_scorescript = _scorescript.GetComponent <scorescript> ();

	}


	public void  destroythisobj1()
	{
		Obj1.enabled = false;
		ThisCanvasObj.enabled = false;
		GravityOff.isKinematic = true;
		GravityOff.detectCollisions = false;
	}

	public void ShowBoxSlot()
	{
		BoxSlot.enabled = true;
	}

	public void ShowBoxSlot2()
	{
		BoxSlot2.enabled = true;
	}

	public void ShowBoxSlot3()
	{
		BoxSlot3.enabled = true;
	}
		

	// Update is called once per frame

	void Update()
	{
		PlayerPrefs.SetInt ("hiscore", _scorescript.hiscorecount);

		if (BoxSlot.enabled == true && BoxSlot2.enabled == true && BoxSlot3.enabled == true) {
			_scorescript.scorecount = _scorescript.addCount;
			_scorescript.scoretext.text = "Score: " + _scorescript.scorecount;
			if (_scorescript.scorecount >= _scorescript.hiscorecount) {
				_scorescript.hiscorecount = _scorescript.scorecount;
				_scorescript.hiscoretxt.text = "Hi-Score: "+ PlayerPrefs.GetInt("hiscore");

			}
			PlayerPrefs.SetInt("scoresession", _scorescript.scorecount);
			SceneManager.LoadScene ("ObjectLvl2");
			PlayerPrefs.Save ();
		}

	}


}
