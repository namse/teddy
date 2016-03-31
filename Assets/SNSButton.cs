using UnityEngine;
using System.Collections;

public class SNSButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void openTwitter() {
		Application.OpenURL("https://twitter.com/teddy4jp");
	}

	public void openFacebook() {
		Application.OpenURL("https://www.facebook.com/teddy4jp");
	}

	public void openInstagram() {
		Application.OpenURL("https://instagram.com/teddy4jp");
	}

	public void openLine() {
		Application.OpenURL("https://line.me/ti/p/%40zbv5646g");
	}
}
