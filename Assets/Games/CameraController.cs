using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CameraController : MonoBehaviour {
	public float zoomSpeed = 1;
	public float targetOrtho;
	public float smoothSpeed = 2.0f;
	public float minOrtho = 1.0f;
	public float maxOrtho = 20.0f;
	private float zoomLevel = 0f;
	private float currentTime = 0f;
	private float timeStep = PlatformController.Timestep;
	private ReserveList<float> zoomReserveList = new ReserveList<float>(); // key : time, value : zoomLevel
	// Use this for initialization
	private float startOrtho;
	private float center;
	void Start () {
		startOrtho = targetOrtho = Camera.main.orthographicSize;
		center = Camera.main.transform.position.y;

		zoomReserveList.ReserveWithBeat (28, 6f);
		PlatformController.CameraControllerReady = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlatformController.StartedSong) {

			if (zoomLevel != 0.0f) {
				targetOrtho = zoomLevel;
//			targetOrtho -= zoomLevel * zoomSpeed;
				targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
			}
			Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
			Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, ((targetOrtho / startOrtho) * (center - (-2.0f))) + (-2.0f), Camera.main.transform.position.z);
		}
	}

	void FixedUpdate()
	{	
		currentTime += timeStep; 

		float zoomValue = 0;
		if (zoomReserveList.PopAvailableValue (currentTime, ref zoomValue)) {
			Zoom (zoomValue);
		}
	}

	public void Zoom(float zoomLevel)
	{
		this.zoomLevel = zoomLevel;
	}


}
