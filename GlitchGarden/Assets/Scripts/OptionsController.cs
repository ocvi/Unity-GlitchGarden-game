﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider diffSlider;
	public LevelManager levelManager;
	private MusicManager musicManager;
	

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefManager.GetMasterVolume();
		diffSlider.value = PlayerPrefManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume(volumeSlider.value);
	}
	
	public void SaveAndExit(){
		PlayerPrefManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefManager.SetDifficulty(diffSlider.value);
		levelManager.LoadLevel("Start Menu");
	}
}
