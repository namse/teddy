using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class HurdleController: MonoBehaviour {

	public Flower FlowerPrefab;
	[HideInInspector] public float currentBeat = 0;

	public static float endX = float.PositiveInfinity;
	public static float readyRange = 15;
	public static float deadLine = -15;
	ReserveList<float> flowerList = new ReserveList<float>();
	List<Flower> workingFlowerList = new List<Flower>();
	List<Flower> readyFlowerList = new List<Flower>();
	float count = 0;
	float currentTime = 0;
	float notePrepareTime = 0;
	float notePrepareBeat = 0;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++){
			Flower flower = (Flower)Instantiate (FlowerPrefab, new Vector3(-5f,0,0), Quaternion.identity);
			readyFlowerList.Add(flower);
		}

		InitHurdle ();

		PlatformController.HurdleControllerReady = true;
	}

	void Update(){
		if (PlatformController.StartedSong) {
			float flowerX = new float();
			if(flowerList.PopAvailableValue(transform.position.x + readyRange, ref flowerX)){
				Flower flower;
				if(readyFlowerList.Count > 0){
					flower = readyFlowerList[0];
					readyFlowerList.RemoveAt(0);
				} else {
					flower = (Flower)Instantiate (FlowerPrefab);
				}
				workingFlowerList.Add(flower);
				flower.transform.position = new Vector3(flowerX,-0.7f, 0);
			}
			foreach (Flower flower in workingFlowerList.ToArray()) {
				if (flower.transform.position.x <= transform.position.x - deadLine) {
					readyFlowerList.Add (flower);
					workingFlowerList.Remove (flower);
				}
			}
		}
	}

	void InitHurdle(){

		if (PlatformController.currentSongStep == AppData.Step.One) {

            AddRest(5 - 0.4f);

			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (3.5f);
			AddFlowerWithDeltaBeat (3.5f);
			AddFlowerWithDeltaBeat (3.5f);
			AddFlowerWithDeltaBeat (3.75f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (8.25f);
			AddFlowerWithDeltaBeat (7.75f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (8.25f);
			AddFlowerWithDeltaBeat (8f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (8f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (3f);
			AddFlowerWithDeltaBeat (3f);
			AddFlowerWithDeltaBeat (6f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (3.75f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1.25f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (6.25f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (6f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (10f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (2.5f);
			AddFlowerWithDeltaBeat (4.75f);
			AddFlowerWithDeltaBeat (12.5f);
			AddEndPoint ();


		} else if (PlatformController.currentSongStep == AppData.Step.Two) {

			AddRest (5 - 0.125f);
			AddFlowerWithDeltaBeat (4.3f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (3.75f);
			AddFlowerWithDeltaBeat (4.25f);
			AddFlowerWithDeltaBeat (3.75f);
			
			AddFlowerWithDeltaBeat (2.25f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			// --------------------- 따레노가~
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (3f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (3f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (3f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (3f);
			
			// 지누~ 사~
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddRest (0.25f);
			
			//------------------------ 닛뽄씨가아
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			// ------------------------------ 똑! 교오츠카니~
			AddRest (0.125f);
			
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			// --------------------------------
			// 세션
			AddRest (0.25f);
			
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (1.25f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (1.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (1.25f);
			AddFlowerWithDeltaBeat (2.25f);
			
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (4.125f);
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f + 0.05f);
			AddFlowerWithDeltaBeat (1.75f);
			
			/// -------------------
			
			
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			// -------------------------------
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			// -------------------
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (2f);
			
			
			// ---------------------------
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1.05f);
			AddFlowerWithDeltaBeat (1.05f);  

			AddRest(2.0f);
			AddEndPoint ();

		} else if (PlatformController.currentSongStep == AppData.Step.Three) {
			AddRest (7f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddRest (2f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			
			
			AddFlowerWithDeltaBeat (1f, 1);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (1.5f);
			
			
			AddFlowerWithDeltaBeat (8f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (1.5f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (2.25f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddRest (4.5f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (2f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (4f);
			
			
			AddFlowerWithDeltaBeat (4f);
			AddRest (4f);
			AddRest (4f);
			AddRest (4f);
			
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			AddFlowerWithDeltaBeat (4f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1f);
			
			AddFlowerWithDeltaBeat (1f);
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1f);
			
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (2f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.25f);
			AddFlowerWithDeltaBeat (0.75f);
			
			AddFlowerWithDeltaBeat (3.0f);
			AddFlowerWithDeltaBeat (0.25f);
			AddFlowerWithDeltaBeat (0.75f);
			
			
			AddFlowerWithDeltaBeat (2.0f);
			AddFlowerWithDeltaBeat (2.0f);
			AddFlowerWithDeltaBeat (2.0f);
			AddFlowerWithDeltaBeat (2.0f);
			
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			
			
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (1.5f);
			AddFlowerWithDeltaBeat (0.5f);
			
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (1.75f);
			
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			
			AddFlowerWithDeltaBeat (0.25f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.75f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.5f);
			AddFlowerWithDeltaBeat (1.0f);
			
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (0.5f);
			
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			AddFlowerWithDeltaBeat (1.0f);
			
			AddFlowerWithDeltaBeat (2.0f); 
			AddFlowerWithDeltaBeat (2.0f);

			AddRest(2.0f);
			AddEndPoint ();
		}
		
		//AddEndPoint ();
	}

	float GetDistanceWithBeatOfSong(AppData.Step step, float beat){
		float ret = float.NaN;
		float moveSpeed = PlatformController.moveSpeed;
		float bps_89 = 89f/60f;
		float bps_95 = 95f/60f;
		float bps_93 = 93f/60f;
		float distancePerBeat_89 = moveSpeed / bps_89;
		float distancePerBeat_95 = moveSpeed / bps_95;
		float distancePerBeat_93 = moveSpeed / bps_93;
		if (step == AppData.Step.One) {
			ret = beat * distancePerBeat_95;
		} else if (step == AppData.Step.Two) {
			ret = beat * distancePerBeat_93;
		} else if (step == AppData.Step.Three) {
			// first Flower until 00:20:50 // 30박
			if (beat < 30) {
				ret = beat * distancePerBeat_89;
			} else {
				ret = 30 * distancePerBeat_89 + (beat - 30) * distancePerBeat_95;
			}
		}
		return ret;
	}

	void AddEndPoint() {
		endX = GetDistanceWithBeatOfSong(PlatformController.currentSongStep, currentBeat);
	}

	void AddRest(float beat){
		currentBeat += beat;
	}

	void AddFlowerWithDeltaBeat(float deltaBeat, int tag = 0)
	{
		AddFlower(GetDistanceWithBeatOfSong(PlatformController.currentSongStep, currentBeat),tag);
		currentBeat += deltaBeat;
	}

	void AddFlower(float x, int tag){
		//var flower = (Flower)Instantiate (FlowerPrefab, new Vector3(x, -0.7f, 0), Quaternion.identity);
		//flower.testTag = tag;
		flowerList.Reserve(x, x);
	}

}
