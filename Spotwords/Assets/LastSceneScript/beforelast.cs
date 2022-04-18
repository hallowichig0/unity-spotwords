using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class beforelast : MonoBehaviour {

	public scorescript _scorescript;


	// Use this for initialization
	void Start () {
		


	}



	// Update is called once per frame
	void Update()
	{
		if (_scorescript.scorecount >= _scorescript.hiscorecount) {

			SceneManager.LoadScene ("LastScene");
		}
	}
}
