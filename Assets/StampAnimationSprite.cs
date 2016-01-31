using UnityEngine;
using System.Collections;

public class StampAnimationSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StopAnimation(){
		Animator animator = GetComponent<Animator> ();
		animator.Play ("StopStamp");
	}
}
