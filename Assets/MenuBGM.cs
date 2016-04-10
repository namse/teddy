using UnityEngine;
using System.Collections;

public class MenuBGM : MonoBehaviour {

    public AudioSource BGM1AudioSoundSource;
    public AudioSource BGM2AudioSoundSource;
    private AudioSource CurrentPlayingBGM = null;

    private int CurrentWaitingTime = 0;
	// Use this for initialization
	void Start () {
        CurrentWaitingTime = (int)(3 / 0.02);
	}

    void FixedUpdate()
    {
        if (CurrentPlayingBGM == null || CurrentPlayingBGM.isPlaying == false)
        {
            CurrentWaitingTime++; // 0.02 second for 1 timestep
            if (CurrentWaitingTime >= 3 / 0.02)
            {
                CurrentWaitingTime = 0;
                if (Random.Range(0, 2) == 0)
                {
                    CurrentPlayingBGM = BGM1AudioSoundSource;
                }
                else
                {
                    CurrentPlayingBGM = BGM2AudioSoundSource;
                }
                CurrentPlayingBGM.Play();
            }
        }
    }
}
