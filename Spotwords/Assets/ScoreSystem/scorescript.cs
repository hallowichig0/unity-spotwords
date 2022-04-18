using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scorescript : MonoBehaviour {

	public Text scoretext;
	public Text hiscoretxt;
	public int scorecount;
	public int hiscorecount;
	public int addCount;
	// Use this for initialization
	void Start () {
		

		scoretext = scoretext.GetComponent <Text> ();
		hiscoretxt = hiscoretxt.GetComponent <Text> ();
		scorecount = PlayerPrefs.GetInt ("scoresession");
		hiscorecount = PlayerPrefs.GetInt ("hiscore");

	}

	public void addScorePerClick()
	{
		scorecount = scorecount + 250;
		addCount = scorecount + 1000;
	}
	
	// Update is called once per frame
	void Update () {
		
		scoretext.text = "Score: " + scorecount;
		hiscoretxt.text = "Hi-Score: " + hiscorecount;
		if (scorecount >= hiscorecount) {
			hiscorecount = scorecount;
			hiscoretxt.text = "Hi-Score: " + PlayerPrefs.GetInt("hiscore");
		}

	}
}
