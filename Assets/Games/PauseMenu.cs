using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public AudioSource againAudioSource;
	public AudioSource endAudioSource;
	// Use this for initialization
	void Start () {
		Debug.Log ("PauseMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPause(){
		Debug.Log ("hi");
		Animator anim = GetComponent<Animator> ();
		anim.Play ("PauseMenuOnPause");

	}

	public void OnStop(){
		endAudioSource.Play();
		StartCoroutine(WaitAndLoadLevel(2, "Menu"));

	}

	public void Restart(){
		againAudioSource.Play();
		StartCoroutine(WaitAndLoadLevel(1, Application.loadedLevel));
	}

	public IEnumerator WaitAndLoadLevel(float waitTime, string level) {
		while (true) {
			yield return new WaitForSeconds(waitTime);
			Application.LoadLevel (level);
		}
	}
	public IEnumerator WaitAndLoadLevel(float waitTime, int level) {
		while (true) {
			yield return new WaitForSeconds(waitTime);
			Application.LoadLevel (level);
		}
	}
}
