using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public StampAnimationSprite stampAnimationSpritePrefab;
	public RectTransform StepStart;
	public RectTransform Step1Image;
	public RectTransform Step2Image;
	public RectTransform Step3Image;
	public GameObject canvas;
	public Animator MenuBearAnimator;
	public GameObject MenuBear;
	public AudioSource StampAudioSource;

	public AudioSource BGM1AudioSoundSource;
	public AudioSource BGM2AudioSoundSource;
	private AudioSource CurrentPlayingBGM = null;
	private int CurrentWaitingTime = 0;
	// Use this for initialization
	void Start () {
		// 스테이지 깨지 않았으면 항상 NULL이도록 할 것.
		if (AppData.DidClearStep != AppData.Step.NULL ) {
			StampAudioSource.Play();
		} else {
			MenuBearAnimator.SetInteger("currentStep", (int)AppData.CurrentStep);
		}
		MenuBearAnimator.SetInteger("clearStep", (int)AppData.DidClearStep);

		var stampStart = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, StepStart.position, Quaternion.identity);
		stampStart.transform.SetParent(canvas.transform);
		stampStart.transform.localScale = new Vector3 (1f, 1f, 1f);
		if (AppData.DidClearStep != AppData.Step.Start) {
			stampStart.StopAnimation ();
		}

		if (AppData.CurrentStep != AppData.Step.One) {
			var stamp1 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step1Image.position, Quaternion.identity);
			stamp1.transform.SetParent(canvas.transform);
			stamp1.transform.localScale = new Vector3 (1f, 1f, 1f);
			if (AppData.DidClearStep != AppData.Step.One) {
				stamp1.StopAnimation();
			}

			if (AppData.CurrentStep != AppData.Step.Two) {
				var stamp2 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step2Image.position, Quaternion.identity);
				stamp2.transform.SetParent(canvas.transform);
				stamp2.transform.localScale = new Vector3 (1f, 1f, 1f);
				if (AppData.DidClearStep != AppData.Step.Two) {
					stamp2.StopAnimation();
				}

				if (AppData.CurrentStep != AppData.Step.Three) {
					var stamp3 = (StampAnimationSprite) Instantiate(stampAnimationSpritePrefab, Step3Image.position, Quaternion.identity);
					stamp3.transform.SetParent(canvas.transform);
					stamp3.transform.localScale = new Vector3 (1f, 1f, 1f);
					if (AppData.DidClearStep != AppData.Step.Three) {
						stamp3.StopAnimation();
					}
				}
			}
		}
		MenuBear.transform.SetAsLastSibling ();
		AppData.DidClearStep = AppData.Step.NULL;
		SetIsWalking();
	}

	// Update is called once per frame
	void Update () {
		SetIsWalking();
	}

	void FixedUpdate () {
		if (CurrentPlayingBGM == null || CurrentPlayingBGM.isPlaying == false) {
			CurrentWaitingTime++; // 0.02 second for 1 timestep
			if (CurrentWaitingTime >= 3 / 0.02) {
				CurrentWaitingTime = 0;
				if ( Random.Range(0, 1) == 0 ) {
					CurrentPlayingBGM = BGM1AudioSoundSource;
				} else {
					CurrentPlayingBGM = BGM2AudioSoundSource;
				}
				CurrentPlayingBGM.Play();
			}
		}
	}

	public void StartStep1() {
		if ((int)AppData.CurrentStep >= (int)AppData.Step.One) {
			PlatformController.currentSongStep = AppData.Step.One;
			Application.LoadLevel("game");
		}
	}


	public void StartStep2() {
		if ((int)AppData.CurrentStep >= (int)AppData.Step.Two) {
			PlatformController.currentSongStep = AppData.Step.Two;
			Application.LoadLevel("game");
		}
	}

	public void StartStep3() {
		if ((int)AppData.CurrentStep >= (int)AppData.Step.Three) {
			PlatformController.currentSongStep = AppData.Step.Three;
			Application.LoadLevel("game");
		}
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
