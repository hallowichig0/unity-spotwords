using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deductionscore12 : MonoBehaviour {

	public Button deductionButton2;
	public scorescript _scorescript;
	// Use this for initialization
	void Start () {
		deductionButton2 = deductionButton2.GetComponent <Button> ();
	}

	public void DeductionClick()
	{
		_scorescript.scorecount = _scorescript.scorecount - 250;
		_scorescript.addCount = _scorescript.addCount - 250;
	}
	
	// Update is called once per frame

}
