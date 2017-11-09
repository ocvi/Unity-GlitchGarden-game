﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defenders : MonoBehaviour {

	private StarDisplay starDisplay;
	public int starCost = 100;
	
	void Start(){
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

	public void AddStars (int amount){
		starDisplay.AddStars(amount);
	}
}
