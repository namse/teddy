using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		StartCoroutine(WaitAndLoadLevel(4.2f, "start"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator WaitAndLoadLevel(float waitTime, string level) {
		while (true) {
			yield return new WaitForSeconds(waitTime);
			Application.LoadLevel (level);
		}
	}
}
