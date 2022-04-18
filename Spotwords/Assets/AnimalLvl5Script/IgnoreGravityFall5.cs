using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class IgnoreGravityFall5 : MonoBehaviour {

	public Rigidbody GravityOff;

	void Start() {
		GravityOff = GravityOff.GetComponent <Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y <= Time.deltaTime)
		{
			GravityOff.isKinematic = true;
			GravityOff.detectCollisions = false;
		}
	}
}
