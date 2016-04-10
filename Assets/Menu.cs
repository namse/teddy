using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

	public StampAnimationSprite stampAnimationSpritePrefab;
	public RectTransform StepStart;
	public RectTransform Step1Image;
	public RectTransform Step2Image;
	public RectTransform Step3Image;
	public GameObject canvas;
    public Animator MenuBearAnimator;
    public Animator OpenButtonAnimator;
	public GameObject MenuBear;
	public AudioSource StampAudioSource;
	public Image Omedeto;

	// Use this for initialization
    void Start()
    {
		var currentStep = AppData.getCurrentStep();
		var didClearStep = AppData.getDidClearStep();
		// 스테이지 깨지 않았으면 항상 NULL이도록 할 것.
		if (didClearStep != AppData.Step.NULL ) {
			StampAudioSource.Play();
		}
        MenuBearAnimator.SetInteger("currentStep", (int)currentStep);
		MenuBearAnimator.SetInteger("clearStep", (int)didClearStep);

        var isClearAll = (currentStep == AppData.Step.Goal);
        OpenButtonAnimator.SetBool("OpenButton", isClearAll);

		if (currentStep > AppData.Step.One) {
			var stamp1 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step1Image.position, Quaternion.identity);
			stamp1.transform.SetParent(canvas.transform);
			stamp1.transform.localScale = new Vector3 (1f, 1f, 1f);
			if (didClearStep != AppData.Step.One) {
				stamp1.StopAnimation();
			}

			if (currentStep > AppData.Step.Two) {
				var stamp2 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step2Image.position, Quaternion.identity);
				stamp2.transform.SetParent(canvas.transform);
				stamp2.transform.localScale = new Vector3 (1f, 1f, 1f);
				if (didClearStep != AppData.Step.Two) {
					stamp2.StopAnimation();
				}

				if (currentStep > AppData.Step.Three) {
					var stamp3 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step3Image.position, Quaternion.identity);
					stamp3.transform.SetParent(canvas.transform);
					stamp3.transform.localScale = new Vector3 (1f, 1f, 1f);
					if (didClearStep != AppData.Step.Three) {
						stamp3.StopAnimation();
					}
					Omedeto.enabled = true;
				}
			}
		}
		MenuBear.transform.SetAsLastSibling ();
		AppData.setDidClearStep(AppData.Step.NULL);
		SetIsWalking();
	}

	// Update is called once per frame
	void Update () {
		SetIsWalking();
	}

	public void StartStep1() {
		if ((int)AppData.getCurrentStep() >= (int)AppData.Step.One) {
			PlatformController.currentSongStep = AppData.Step.One;
			Application.LoadLevel("game");
		}
	}


	public void StartStep2() {
		if ((int)AppData.getCurrentStep() >= (int)AppData.Step.Two) {
			PlatformController.currentSongStep = AppData.Step.Two;
			Application.LoadLevel("game");
		}
	}

	public void StartStep3() {
		if ((int)AppData.getCurrentStep() >= (int)AppData.Step.Three) {
			PlatformController.currentSongStep = AppData.Step.Three;
			Application.LoadLevel("game");
		}
	}

	public void OpenInfo() {
		Application.LoadLevel("Info");
	}

	void SetIsWalking(){
		var stateInfo = MenuBearAnimator.GetCurrentAnimatorStateInfo(0);
		if ( stateInfo.IsName("MenuOne") || stateInfo.IsName("MenuTwo") || stateInfo.IsName("MenuThree") || stateInfo.IsName("MenuGoal")) {
			MenuBearAnimator.SetBool("isWalking", false);
		} else {
			MenuBearAnimator.SetBool("isWalking", true);
		}
	}
}
