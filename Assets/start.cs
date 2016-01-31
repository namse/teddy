using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public AudioSource startAudioSource;
	// Use this for initialization
	void Start () {
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


	public void GotoMenu(){
		startAudioSource.Play();
		StartCoroutine(WaitAndLoadLevel(1, "Menu"));
	}
}
