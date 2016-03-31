using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	[HideInInspector] public bool jump;

	public Transform cameraTransform;
	public static float moveSpeed = 5f;
	public static float jumpSpeedInitial = 14f;
	public static float g = 61;
	public Transform groundCheck;


	private bool isGrounded = false;
	private Animator anim;
	private Rigidbody2D rb2d;
	private float currentYVelocity = 0;

	public AudioSource gameOverBGMAudioSource;
	public AudioSource[] gameOverAudioSources;

	public Ground GroundPrefab;
	private Ground[] groundList;
	private const int GroundCount = 5;
	private int frontGroundIndex = 0;
	public const int MaximumfrontGroundDistance = 30;

	public const float Timestep = 0.01f;
	private int jumpCount = 0;
	private const int maxJumpCount = 2;
	// Use this for initialization

	public BeatSynchronizer[] beatSynchronizer;
	public static bool StartedSong = false; 
	public static bool PlatformControllerReady = false;
	public static bool HurdleControllerReady = false;
	public static bool CloudControllerReady = false;
	public static bool CameraControllerReady = false;

	public AudioSource[] audioSource;
	public bool dieTrigger = true;
	private bool isDead = false;
	private int dieTime = 0;
	public PauseMenu menu;
	private bool dieEnd = false;

	public static AppData.Step currentSongStep;

	public float CameraPositionX;
	void Awake(){
		StartedSong = false;

		cameraTransform.position = new Vector3 (this.transform.position.x, cameraTransform.position.y, cameraTransform.position.z);
		anim = GetComponent<Animator> ();
		rb2d = GetComponent<Rigidbody2D> ();
		jump = false;
		groundList = new Ground[GroundCount];

		for (int i = 0; i < GroundCount; i++) {
			GenerateGround (i);
		}
		PlatformControllerReady = true;
	}
	// Update is called once per frame
	void Update () {
		if (!isDead) {
			if (StartedSong == false && 
				PlatformControllerReady == true &&
				HurdleControllerReady == true &&
				CloudControllerReady == true /*&&
				CameraControllerReady == true*/) {

				beatSynchronizer[(int)currentSongStep].SongStart ();
				StartedSong = true;
			}
			if (StartedSong) {
				if ((Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown(0) ) && jumpCount < maxJumpCount) {
					jump = true;
					currentYVelocity = 0;
					jumpCount++;
					isGrounded = false;
				}
				RollGround ();
				if(HurdleController.endX <= transform.position.x){
					// Finish!
					AppData.ClearStep(currentSongStep);
					Application.LoadLevel("Menu");

				}
			}
		}
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Hurdle")
		{
			Destroy(coll.gameObject);
			Debug.Log("wow!");
			var anim = GetComponent<Animator>();
			anim.Play("die");
			isDead = true;
			audioSource[(int)currentSongStep].Stop();
			gameOverBGMAudioSource.Play();

			int gameOverAudioIndex = Random.Range(1, gameOverAudioSources.Length);
			gameOverAudioSources[gameOverAudioIndex].Play();
		}
	}
	
	void FixedUpdate()
	{
		if (isDead) {
			if(dieEnd == false){
				if(dieTime > 60){
					menu.GetComponent<Animator>().Play("PauseMenuOnDie");
					dieEnd = true;
				}else {
					dieTime++;
				}
			}
		} else {
			if (StartedSong) {
				//anim.SetFloat ("Speed", 1);

				if (jump) {
					currentYVelocity = Mathf.Pow (Mathf.Pow (currentYVelocity, 2) + Mathf.Pow (jumpSpeedInitial, 2), 0.5f);
					jump = false;
				}

				if (isGrounded == false) {
					float g_ = g;
					if (jumpCount >= 2)
						g_ *= 1.3f;
					currentYVelocity += -g_ * Timestep;
				}

				if (transform.position.y + currentYVelocity * Timestep <= 0) {
					isGrounded = true;
					jumpCount = 0;
					transform.position += new Vector3 (moveSpeed * Timestep, -transform.position.y, 0);
					currentYVelocity = 0;
				} else {
					transform.position += new Vector3 (moveSpeed * Timestep, currentYVelocity * Timestep, 0);
				}
				cameraTransform.position = new Vector3 (this.transform.position.x + CameraPositionX, cameraTransform.position.y, cameraTransform.position.z);
			}
		}
	}

	void GenerateGround(int index)
	{
		groundList[index] = (Ground)Instantiate (GroundPrefab);
		groundList [index].transform.position = new Vector3 (index * groundList[index].width, 3.6f, 0);
	}

	void RollGround()
	{
		if (groundList [frontGroundIndex].transform.position.x + MaximumfrontGroundDistance < transform.position.x) {
			groundList [frontGroundIndex].transform.position += new Vector3 (GroundCount * groundList[frontGroundIndex].width, 0, 0);
			++frontGroundIndex;
			if(frontGroundIndex >= GroundCount)
			{
				frontGroundIndex = 0;
			}
			RollGround ();
		}
	}
}
