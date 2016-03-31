using UnityEngine;
using System.Collections;

public class AppData{
	public enum Step { NULL = -2, Start = -1, One = 0, Two = 1, Three = 2, Goal = 3};
	//public static Step CurrentStep = Step.One; // 현재 내가 밟고있는 곳. 내가 깨야하는 곳
	//public static Step DidClearStep = Step.Start; // 스테이지 깨지 않았으면 항상 NULL이도록 할 것.


	public static void ClearStep(Step step){
		if (step == getCurrentStep()) {
			setDidClearStep(step);
			setCurrentStep(step+1);
		}
	}

	public static void setCurrentStep(Step step) {
		PlayerPrefs.SetInt("currentstep", (int)step);
	}
	
	public static Step getCurrentStep() {
		if(PlayerPrefs.HasKey("currentstep")){
			return (Step)PlayerPrefs.GetInt("currentstep");
		} else {
			setCurrentStep(Step.One);
			return Step.One;
		}
	}

	public static void setDidClearStep(Step step) {
		PlayerPrefs.SetInt("didclearstep", (int)step);
	}
	
	public static Step getDidClearStep() {
		if(PlayerPrefs.HasKey("didclearstep")){
			return (Step)PlayerPrefs.GetInt("didclearstep");
		} else {
			setDidClearStep(Step.Start);
			return Step.Start;
		}
	}
}
