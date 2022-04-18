using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class scorescenescript : MonoBehaviour {

	public Button BackToMain;
	public scorescript _scorescirpt;
	public Text codename;
	public Text codename2;
	public Text codename3;
	public Text codename4;
	public Text codename5;
	public Text codename6;
	public Text codename7;
	public Text codename8;
	public Text codename9;
	public Text codename10;
	public Text codename11;
	public Text codename12;
	public Text codename13;
	public Text codename14;
	public Text codename15;
	public Text codename16;
	public Text codename17;
	public Text codename18;
	public Text codename19;
	public Text codename20;
	public Text codename21;
	public Text Toplistname;
	public Text Toplistname2;
	public Text Toplistname3;
	public Text Toplistname4;
	public Text Toplistname5;
	public Text Toplistname6;
	public Text Toplistname7;
	public Text Toplistname8;
	public Text Toplistname9;
	public Text Toplistname10;
	public Text Toplistname11;
	public Text Toplistname12;
	public Text Toplistname13;
	public Text Toplistname14;
	public Text Toplistname15;
	public Text Toplistname16;
	public Text Toplistname17;
	public Text Toplistname18;
	public Text Toplistname19;
	public Text Toplistname20;
	public Text Toplistname21;


	// Use this for initialization
	void Start () {
		BackToMain = BackToMain.GetComponent <Button> ();
		codename = codename.GetComponent <Text> ();
		Toplistname = Toplistname.GetComponent <Text> ();
		Toplistname2 = Toplistname2.GetComponent <Text> ();
		Toplistname3 = Toplistname3.GetComponent <Text> ();
		Toplistname4 = Toplistname4.GetComponent <Text> ();
		Toplistname5 = Toplistname5.GetComponent <Text> ();
		_scorescirpt.scoretext.enabled = false;


	}



	public void BackMenuButton()
	{
		SceneManager.LoadScene ("GameMenu");
	}

	void Update() {
		codename.text = PlayerPrefs.GetString ("name1");
		Toplistname.text = codename.text + ": " + PlayerPrefs.GetInt("topscore1");


		codename2.text = PlayerPrefs.GetString ("name2");
		Toplistname2.text = codename2.text + ": " + PlayerPrefs.GetInt("topscore2");

		codename3.text = PlayerPrefs.GetString ("name3");
		Toplistname3.text = codename3.text + ": " + PlayerPrefs.GetInt("topscore3");

		codename4.text = PlayerPrefs.GetString ("name4");
		Toplistname4.text = codename4.text + ": " + PlayerPrefs.GetInt("topscore4");

		codename5.text = PlayerPrefs.GetString ("name5");
		Toplistname5.text = codename5.text + ": " + PlayerPrefs.GetInt("topscore5");

		codename6.text = PlayerPrefs.GetString ("name6");
		Toplistname6.text = codename6.text + ": " + PlayerPrefs.GetInt("topscore6");

		codename7.text = PlayerPrefs.GetString ("name7");
		Toplistname7.text = codename7.text + ": " + PlayerPrefs.GetInt("topscore7");

		codename8.text = PlayerPrefs.GetString ("name8");
		Toplistname8.text = codename8.text + ": " + PlayerPrefs.GetInt("topscore8");

		codename9.text = PlayerPrefs.GetString ("name9");
		Toplistname9.text = codename9.text + ": " + PlayerPrefs.GetInt("topscore9");

		codename10.text = PlayerPrefs.GetString ("name10");
		Toplistname10.text = codename10.text + ": " + PlayerPrefs.GetInt("topscore10");

		codename11.text = PlayerPrefs.GetString ("name11");
		Toplistname11.text = codename11.text + ": " + PlayerPrefs.GetInt("topscore11");

		codename12.text = PlayerPrefs.GetString ("name12");
		Toplistname12.text = codename12.text + ": " + PlayerPrefs.GetInt("topscore12");

		codename13.text = PlayerPrefs.GetString ("name13");
		Toplistname13.text = codename13.text + ": " + PlayerPrefs.GetInt("topscore13");

		codename14.text = PlayerPrefs.GetString ("name14");
		Toplistname14.text = codename14.text + ": " + PlayerPrefs.GetInt("topscore14");

		codename15.text = PlayerPrefs.GetString ("name15");
		Toplistname15.text = codename15.text + ": " + PlayerPrefs.GetInt("topscore15");

		codename16.text = PlayerPrefs.GetString ("name16");
		Toplistname16.text = codename16.text + ": " + PlayerPrefs.GetInt("topscore16");

		codename17.text = PlayerPrefs.GetString ("name17");
		Toplistname17.text = codename17.text + ": " + PlayerPrefs.GetInt("topscore17");

		codename18.text = PlayerPrefs.GetString ("name18");
		Toplistname18.text = codename18.text + ": " + PlayerPrefs.GetInt("topscore18");

		codename19.text = PlayerPrefs.GetString ("name19");
		Toplistname19.text = codename19.text + ": " + PlayerPrefs.GetInt("topscore19");

		codename20.text = PlayerPrefs.GetString ("name20");
		Toplistname20.text = codename20.text + ": " + PlayerPrefs.GetInt("topscore20");

		codename21.text = PlayerPrefs.GetString ("name21");
		Toplistname21.text = codename21.text + ": " + PlayerPrefs.GetInt("topscore21");

		if (PlayerPrefs.GetInt ("topscore2") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname2.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");

		}
		if (PlayerPrefs.GetInt ("topscore3") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname2.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname3.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore4") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname2.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname3.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname4.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore5") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname2.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname3.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname4.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname5.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore6") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname2.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname3.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname4.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname5.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname6.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore7") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname2.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname3.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname4.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname5.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname6.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname7.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore8") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname2.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname3.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname4.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname5.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname6.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname7.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname8.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore9") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname2.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname3.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname4.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname5.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname6.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname7.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname8.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname9.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if (PlayerPrefs.GetInt ("topscore10") >= PlayerPrefs.GetInt ("topscore1")) {
			Toplistname.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname2.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname3.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname4.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname5.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname6.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname7.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname8.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname9.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
			Toplistname10.text = codename.text + ": " + PlayerPrefs.GetInt ("topscore1");
		}
		if(PlayerPrefs.GetInt("topscore11") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname2.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname3.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname4.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname5.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname6.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname7.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname8.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname9.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
			Toplistname10.text = codename2.text + ": " + PlayerPrefs.GetInt ("topscore2");
		}
		if(PlayerPrefs.GetInt("topscore12") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname2.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname3.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname4.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname5.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname6.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname7.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname8.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname9.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
			Toplistname10.text = codename3.text + ": " + PlayerPrefs.GetInt ("topscore3");
		}
		if(PlayerPrefs.GetInt("topscore13") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname2.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname3.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname4.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname5.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname6.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname7.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname8.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname9.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
			Toplistname10.text = codename4.text + ": " + PlayerPrefs.GetInt ("topscore4");
		}
		if(PlayerPrefs.GetInt("topscore14") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname2.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname3.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname4.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname5.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname6.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname7.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname8.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname9.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
			Toplistname10.text = codename5.text + ": " + PlayerPrefs.GetInt ("topscore5");
		}
		if(PlayerPrefs.GetInt("topscore15") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname2.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname3.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname4.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname5.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname6.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname7.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname8.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname9.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
			Toplistname10.text = codename6.text + ": " + PlayerPrefs.GetInt ("topscore6");
		}
		if(PlayerPrefs.GetInt("topscore16") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname2.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname3.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname4.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname5.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname6.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname7.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname8.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname9.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
			Toplistname10.text = codename7.text + ": " + PlayerPrefs.GetInt ("topscore7");
		}
		if(PlayerPrefs.GetInt("topscore17") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename17.text + ": " + PlayerPrefs.GetInt ("topscore17");
			Toplistname2.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname3.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname4.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname5.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname6.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname7.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname8.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname9.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
			Toplistname10.text = codename8.text + ": " + PlayerPrefs.GetInt ("topscore8");
		}
		if(PlayerPrefs.GetInt("topscore18") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename18.text + ": " + PlayerPrefs.GetInt ("topscore18");
			Toplistname2.text = codename17.text + ": " + PlayerPrefs.GetInt ("topscore17");
			Toplistname3.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname4.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname5.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname6.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname7.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname8.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname9.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
			Toplistname10.text = codename9.text + ": " + PlayerPrefs.GetInt ("topscore9");
		}
		if(PlayerPrefs.GetInt("topscore19") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename19.text + ": " + PlayerPrefs.GetInt ("topscore19");
			Toplistname2.text = codename18.text + ": " + PlayerPrefs.GetInt ("topscore18");
			Toplistname3.text = codename17.text + ": " + PlayerPrefs.GetInt ("topscore17");
			Toplistname4.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname5.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname6.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname7.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname8.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname9.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
			Toplistname10.text = codename10.text + ": " + PlayerPrefs.GetInt ("topscore10");
		}
		if(PlayerPrefs.GetInt("topscore20") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename20.text + ": " + PlayerPrefs.GetInt ("topscore20");
			Toplistname2.text = codename19.text + ": " + PlayerPrefs.GetInt ("topscore19");
			Toplistname3.text = codename18.text + ": " + PlayerPrefs.GetInt ("topscore18");
			Toplistname4.text = codename17.text + ": " + PlayerPrefs.GetInt ("topscore17");
			Toplistname5.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname6.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname7.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname8.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname9.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname10.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
		}
		if(PlayerPrefs.GetInt("topscore21") >= PlayerPrefs.GetInt("topscore1")){
			Toplistname.text = codename21.text + ": " + PlayerPrefs.GetInt ("topscore21");
			Toplistname2.text = codename19.text + ": " + PlayerPrefs.GetInt ("topscore19");
			Toplistname3.text = codename18.text + ": " + PlayerPrefs.GetInt ("topscore18");
			Toplistname4.text = codename17.text + ": " + PlayerPrefs.GetInt ("topscore17");
			Toplistname5.text = codename16.text + ": " + PlayerPrefs.GetInt ("topscore16");
			Toplistname6.text = codename15.text + ": " + PlayerPrefs.GetInt ("topscore15");
			Toplistname7.text = codename14.text + ": " + PlayerPrefs.GetInt ("topscore14");
			Toplistname8.text = codename13.text + ": " + PlayerPrefs.GetInt ("topscore13");
			Toplistname9.text = codename12.text + ": " + PlayerPrefs.GetInt ("topscore12");
			Toplistname10.text = codename11.text + ": " + PlayerPrefs.GetInt ("topscore11");
		}

	}
	// Update is called once per frame

}
