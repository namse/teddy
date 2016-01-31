using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	public float speed;
	private bool isStop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isStop == false) {
			this.transform.position = this.transform.position + new Vector3 (-speed, 0, 0);
		}
	}

	public void MoveStop(){
		isStop = true;
	}

	public void MoveStart(){
		isStop = false;
	}
}
