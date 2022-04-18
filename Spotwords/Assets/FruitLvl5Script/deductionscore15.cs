using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deductionscore15 : MonoBehaviour {

	public Button deductionButton;
	public scorescript _scorescript;
	// Use this for initialization
	void Start () {
		deductionButton = deductionButton.GetComponent <Button> ();
	}

	public void DeductionClick()
	{
		_scorescript.scorecount = _scorescript.scorecount - 250;
		_scorescript.addCount = _scorescript.addCount - 250;
	}
	
	// Update is called once per frame

}
