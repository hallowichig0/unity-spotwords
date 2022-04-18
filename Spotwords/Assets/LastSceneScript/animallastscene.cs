using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class animallastscene : MonoBehaviour {


	public Button BackToMain;
	public InputField inputname1;
	public string valuename1;
	public scorescript _scorescript;
	public int autoadd1;


	// Use this for initialization
	void Start () {
		
		BackToMain = BackToMain.GetComponent <Button> ();
		inputname1 = inputname1.GetComponent <InputField> ();




	}

	void Awake()
	{

		autoadd1 = PlayerPrefs.GetInt ("auto1");
		autoadd1  = autoadd1 + 1;
		PlayerPrefs.SetInt ("auto1", autoadd1);

	}




	public void BackMenuButton()
	{

		if (autoadd1 == 1) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name1", valuename1);
				PlayerPrefs.SetInt ("topscore1", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}

		} else if (autoadd1 == 2) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name2", valuename1);
				PlayerPrefs.SetInt ("topscore2", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		} else if (autoadd1 == 3) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name3", valuename1);
				PlayerPrefs.SetInt ("topscore3", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 4) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name4", valuename1);
				PlayerPrefs.SetInt ("topscore4", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 5) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name5", valuename1);
				PlayerPrefs.SetInt ("topscore5", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 6) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name6", valuename1);
				PlayerPrefs.SetInt ("topscore6", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 7) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name7", valuename1);
				PlayerPrefs.SetInt ("topscore7", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 8) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name8", valuename1);
				PlayerPrefs.SetInt ("topscore8", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 9) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name9", valuename1);
				PlayerPrefs.SetInt ("topscore9", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 10) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name10", valuename1);
				PlayerPrefs.SetInt ("topscore10", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 11) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name11", valuename1);
				PlayerPrefs.SetInt ("topscore11", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 12) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name12", valuename1);
				PlayerPrefs.SetInt ("topscore12", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 13) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name13", valuename1);
				PlayerPrefs.SetInt ("topscore13", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 14) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name14", valuename1);
				PlayerPrefs.SetInt ("topscore14", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 15) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name15", valuename1);
				PlayerPrefs.SetInt ("topscore15", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 16) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name16", valuename1);
				PlayerPrefs.SetInt ("topscore16", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 17) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name17", valuename1);
				PlayerPrefs.SetInt ("topscore17", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 18) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name18", valuename1);
				PlayerPrefs.SetInt ("topscore18", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 19) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name19", valuename1);
				PlayerPrefs.SetInt ("topscore19", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 == 20) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name20", valuename1);
				PlayerPrefs.SetInt ("topscore20", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
		else if (autoadd1 > 20) {
			if (inputname1.text.Length < 4) {
				EventSystem.current.SetSelectedGameObject (inputname1.gameObject, null);
				inputname1.OnPointerClick (new PointerEventData (EventSystem.current));
			} else {
				valuename1 = inputname1.text;
				PlayerPrefs.SetString ("name21", valuename1);
				PlayerPrefs.SetInt ("topscore21", _scorescript.hiscorecount);
				SceneManager.LoadScene ("GameMenu");
			}
		}
	}

	// Update is called once per frame

}