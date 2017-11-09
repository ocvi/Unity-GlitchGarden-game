using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
	
	private Slider slider;
	public float levelSeconds = 360;
	private AudioSource audioSource;
	private bool isEndOfLevel = false;
	private LevelManager levelManager;
	private GameObject winLabel;
	
	
	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		FindYouWin ();
		winLabel.SetActive(false);
	}

	void FindYouWin ()
	{
		winLabel = GameObject.Find ("You Win");
		if (winLabel) {
			Debug.LogWarning ("Please create You Win object");
		}
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		if(Time.timeSinceLevelLoad >= levelSeconds && !isEndOfLevel){
			
			audioSource.Play();
			winLabel.SetActive(true);
			Invoke ("LoadNextLevel", audioSource.clip.length);
			isEndOfLevel = true;
			
		}
	}
	
	void LoadNextLevel(){
		levelManager.LoadNextLevel();
	}
}
