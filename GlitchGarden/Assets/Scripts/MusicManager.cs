using UnityEngine;
using System.Collections;

	public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	public AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log("Dont destroy on load" + name);
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level){
		AudioClip thisLvlMusic = levelMusicChangeArray[level];
		Debug.Log ("Playing clip: " + thisLvlMusic);
		
		if(thisLvlMusic){
			audioSource.clip = thisLvlMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void SetVolume (float volume){
		audioSource.volume = volume;
	}
	
	
}
