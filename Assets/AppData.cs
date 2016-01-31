using UnityEngine;
using System.Collections;

public class AppData{
	public enum Step { NULL = -2, Start = -1, One = 0, Two = 1, Three = 2, Goal = 3};
	public static Step CurrentStep = Step.One; // 현재 내가 밟고있는 곳. 내가 깨야하는 곳
	public static Step DidClearStep = Step.Start; // 스테이지 깨지 않았으면 항상 NULL이도록 할 것.

	public static void ClearStep(Step step){
		if (step == CurrentStep) {
			DidClearStep = step;
			CurrentStep = step+1;
		}
	}
}
