using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class HurdleController: MonoBehaviour {

	public Flower[] FlowerPrefabs;
	[HideInInspector] public float currentBeat = 0;

	public static float endX = float.PositiveInfinity;
	public static float readyRange = 15;
	public static float deadLine = -15;
	
	ReserveList<float>[] flowerLists = new ReserveList<float>[3];
	List<Flower>[] workingFlowerLists = new List<Flower>[3];
	List<Flower>[] readyFlowerLists = new List<Flower>[3];

	float count = 0;
	float currentTime = 0;
	float notePrepareTime = 0;
	float notePrepareBeat = 0;
	// Use this for initialization
	void Start () {
		for(int i = 0 ; i < 3; i++){
			flowerLists[i] = new ReserveList<float>();
			workingFlowerLists[i] = new List<Flower>();
			readyFlowerLists[i] = new List<Flower>();
		}
		
		for(int i = 0; i < 10; i++){
			for(var l = 0 ; l < 3; l++){
				Flower flower = (Flower)Instantiate (FlowerPrefabs[l], new Vector3(-5f,0,0), Quaternion.identity);
				readyFlowerLists[l].Add(flower);
			}
		}

		InitHurdle ();

		PlatformController.HurdleControllerReady = true;
	}

	void Update(){
		if (PlatformController.StartedSong) {
			float flowerX = new float();
			for(int i = 0 ; i < 3; i++){
				if(flowerLists[i].PopAvailableValue(transform.position.x + readyRange, ref flowerX)){
					Flower flower;
					if(readyFlowerLists[i].Count > 0){
						flower = readyFlowerLists[i][0];
						readyFlowerLists[i].RemoveAt(0);
					} else {
						flower = (Flower)Instantiate (FlowerPrefabs[i]);
					}
					workingFlowerLists[i].Add(flower);
					flower.transform.position = new Vector3(flowerX,-0.7f, 0);
				}
				foreach (Flower flower in workingFlowerLists[i].ToArray()) {
					if (flower.transform.position.x <= transform.position.x - deadLine) {
						readyFlowerLists[i].Add (flower);
						workingFlowerLists[i].Remove (flower);
					}
				}
			}
		}
	}

	void InitHurdle(){

		if (PlatformController.currentSongStep == AppData.Step.One) {

            AddRest(5 - 0.4f);

			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 3.5f);
			AddFlowerWithDeltaBeat (2, 3.5f);
			AddFlowerWithDeltaBeat (2, 3.5f);
			AddFlowerWithDeltaBeat (2, 3.75f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (0, 8.25f);
			AddFlowerWithDeltaBeat (0, 7.75f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (0, 8.25f);
			AddFlowerWithDeltaBeat (0, 8f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 8f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 3f);
			AddFlowerWithDeltaBeat (2, 3f);
			AddFlowerWithDeltaBeat (0, 6f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 3.75f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1.25f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 6.25f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 6f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 10f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (1, 2.5f);
			AddFlowerWithDeltaBeat (2, 4.75f);
			AddFlowerWithDeltaBeat (2, 12.5f);
			AddEndPoint ();


		} else if (PlatformController.currentSongStep == AppData.Step.Two) {

			AddRest (5 - 0.125f);
			AddFlowerWithDeltaBeat (1, 4.3f);
			AddFlowerWithDeltaBeat (1, 4f);
			AddFlowerWithDeltaBeat (1, 4f);
			AddFlowerWithDeltaBeat (1, 3.75f);
			AddFlowerWithDeltaBeat (1, 4.25f);
			AddFlowerWithDeltaBeat (1, 3.75f);
			
			AddFlowerWithDeltaBeat (1, 2.25f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			// --------------------- 따레노가~
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 3f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 3f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 3f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 3f);
			
			// 지누~ 사~
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddRest (0.25f);
			
			//------------------------ 닛뽄씨가아
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			// ------------------------------ 똑! 교오츠카니~
			AddRest (0.125f);
			
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			// --------------------------------
			// 세션
			AddRest (0.25f);
			
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (0, 1.25f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (0, 1.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (0, 1.25f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (2, 4.125f);
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f + 0.05f);
			AddFlowerWithDeltaBeat (0, 1.75f);
			
			/// -------------------
			
			
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			// -------------------------------
			AddRest (0.15f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			// -------------------
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			
			// ---------------------------
			
			AddRest (0.05f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1.05f);
			AddFlowerWithDeltaBeat (0, 1.05f);  

			AddRest(2.0f);
			AddEndPoint ();

		} else if (PlatformController.currentSongStep == AppData.Step.Three) {
			AddRest (7f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddRest (2f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			
			
			AddFlowerWithDeltaBeat (0, 1f, 1);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			
			
			AddFlowerWithDeltaBeat (0, 8f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (1, 2.25f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddRest (4.5f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (1, 2f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (2, 4f);
			
			
			AddFlowerWithDeltaBeat (2, 4f);
			AddRest (4f);
			AddRest (4f);
			AddRest (4f);
			
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			AddFlowerWithDeltaBeat (2, 4f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			AddFlowerWithDeltaBeat (0, 1f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1f);
			
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (1, 2f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.25f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			
			AddFlowerWithDeltaBeat (2, 3.0f);
			AddFlowerWithDeltaBeat (0, 0.25f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			
			
			AddFlowerWithDeltaBeat (1, 2.0f);
			AddFlowerWithDeltaBeat (1, 2.0f);
			AddFlowerWithDeltaBeat (1, 2.0f);
			AddFlowerWithDeltaBeat (1, 2.0f);
			
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 1.5f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 1.75f);
			
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			
			AddFlowerWithDeltaBeat (0, 0.25f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.75f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.5f);
			
			AddRest (0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 0.5f);
			
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			AddFlowerWithDeltaBeat (0, 1.0f);
			
			AddFlowerWithDeltaBeat (1, 2.0f); 
			AddFlowerWithDeltaBeat (1, 2.0f);

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

	void AddFlowerWithDeltaBeat(int type, float deltaBeat, int tag = 0)
	{
		AddFlower(type, GetDistanceWithBeatOfSong(PlatformController.currentSongStep, currentBeat),tag);
		currentBeat += deltaBeat;
	}

	void AddFlower(int type, float x, int tag){
		flowerLists[type].Reserve(x, x);
	}

}
