using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deductionscore14 : MonoBehaviour {

	public Button deductionButton4;
	public scorescript _scorescript;
	// Use this for initialization
	void Start () {
		deductionButton4 = deductionButton4.GetComponent <Button> ();
	}

	public void DeductionClick()
	{
		_scorescript.scorecount = _scorescript.scorecount - 250;
		_scorescript.addCount = _scorescript.addCount - 250;
	}
	
	// Update is called once per frame

}
