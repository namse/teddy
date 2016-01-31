using UnityEngine;
using System;
using System.Collections.Generic;
public class ReserveList<T>
{
	private SortedList<float, T> reserveList = new SortedList<float, T>(); // key : time, value : 

	public void ReserveWithBeat(float beat, T value)
	{
		float time = float.NaN;
		float bps_89 = 89f/60f;
		float bps_95 = 95f/60f;
		float bps_93 = 93f/60f;
		if (PlatformController.currentSongStep == AppData.Step.One) {
			time = beat / bps_95;
		} else if (PlatformController.currentSongStep == AppData.Step.Two) {
			time = beat / bps_93;
		} else if (PlatformController.currentSongStep == AppData.Step.Three) {
			// first Flower until 00:20:50 // 30박
			if (beat < 30) {
				time = beat / bps_89;
			} else {
				time = 30 / bps_89 + (beat - 30) / bps_95;
			}
		}

		Reserve (time, value);
	}
	
	public void Reserve(float time, T value)
	{
		reserveList.Add (time, value);
	}

	public bool PopAvailableValue(float currentTime, ref T outValue)
	{
		if (reserveList.Count > 0 && reserveList.Keys [0] <= currentTime) {
			outValue = reserveList.Values[0];
			reserveList.RemoveAt(0);
			Debug.Log ("PopValue : " + outValue);
			return true;
		}
		return false;
	}
}

public class ReserveList
{
	private List<float> reserveList = new List<float>(); // key : time, value : 
	
	public void ReserveWithBeat(float beat)
	{
		float bps_95 = 95f/60f;

		Reserve (beat / bps_95);
	}
	
	public void Reserve(float time)
	{
		reserveList.Add (time);
	}
	
	public bool PopAvailableValue(float currentTime)
	{
		if (reserveList.Count > 0 && reserveList[0] <= currentTime) {
			reserveList.RemoveAt(0);
			Debug.Log ("PopValue : true");
			return true;
		}
		return false;
	}
}