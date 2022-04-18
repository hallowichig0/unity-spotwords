using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deductionscore13 : MonoBehaviour {

	public Button deductionButton3;
	public scorescript _scorescript;
	// Use this for initialization
	void Start () {
		deductionButton3 = deductionButton3.GetComponent <Button> ();
	}

	public void DeductionClick()
	{
		_scorescript.scorecount = _scorescript.scorecount - 250;
		_scorescript.addCount = _scorescript.addCount - 250;
	}
	
	// Update is called once per frame

}
