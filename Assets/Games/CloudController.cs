using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloudController : MonoBehaviour {

	public float minPeriod;
	public float maxPeriod;
	public float createDistance;
	public float minY;
	public float maxY;
	public float deadLine;


	public Cloud cloudPrepab;
	private List<Cloud> cloudList = new List<Cloud>();
	private List<Cloud> availableCloud = new List<Cloud>();
	private int accumulatedCount;
	private float nextPeriod;
	// Use this for initialization
	void Start () {
		for(int i = 0 ; i <5 ; i++){
			availableCloud.Add ((Cloud)Instantiate (cloudPrepab, new Vector3(-5f,0,0), Quaternion.identity));
		}
		accumulatedCount = 0;
		UpdateNextPeriod ();
		
		PlatformController.CloudControllerReady = true;
		Debug.Log ("hihi");
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		if (PlatformController.StartedSong) {
			accumulatedCount++;

			if (nextPeriod <= accumulatedCount * PlatformController.Timestep) {
				Cloud cloud;
				if (availableCloud.Count > 0) {
					cloud = availableCloud [0];
					availableCloud.RemoveAt (0);
				} else {
					cloud = (Cloud)Instantiate (cloudPrepab);
				}
				cloudList.Add (cloud);
				cloud.transform.position = new Vector3 (transform.position.x + createDistance, Random.Range (minY, maxY), 0);
				cloud.MoveStart ();
				UpdateNextPeriod ();
				accumulatedCount = 0;
			}


			foreach (Cloud cloud in cloudList.ToArray()) {
				if (cloud.transform.position.x <= transform.position.x - deadLine) {
					cloud.MoveStop ();
					availableCloud.Add (cloud);
					cloudList.Remove (cloud);
				}
			}
		}
	}

	void UpdateNextPeriod(){
		nextPeriod = Random.Range (minPeriod, maxPeriod);
	}
}
