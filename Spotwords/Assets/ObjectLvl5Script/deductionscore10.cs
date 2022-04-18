using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deductionscore10 : MonoBehaviour {

	public Button deductionButton5;
	public scorescript _scorescript;
	// Use this for initialization
	void Start () {
		deductionButton5 = deductionButton5.GetComponent <Button> ();
	}

	public void DeductionClick()
	{
		_scorescript.scorecount = _scorescript.scorecount - 250;
		_scorescript.addCount = _scorescript.addCount - 250;
	}
	
	// Update is called once per frame

}
