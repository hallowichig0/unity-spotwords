using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class top10 : MonoBehaviour {

	public Text n1;
	public Text n2;
	public scorescript _scorescript;
	public int count1;
	public int count2;
	public int addcount1;

	// Use this for initialization
	void Start () {
		n1 = n1.GetComponent<Text> ();
		n2 = n2.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {


		if (_scorescript.hiscorecount >= count1) {
			count1 = _scorescript.hiscorecount;

		}

		if (_scorescript.hiscorecount > count1) {
			
			count2 = addcount1;
			PlayerPrefs.SetInt ("n2s", count2);
			n2.text = "2nd: " + PlayerPrefs.GetInt("n2s");
			count1 = _scorescript.hiscorecount;
		}
		count1 = _scorescript.hiscorecount;





		
		n1.text = "1st: " + count1;
	}
}
