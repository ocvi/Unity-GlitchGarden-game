﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent (typeof (Health))]
public class Attackers : MonoBehaviour {
	[Tooltip ("Average number of seconds between appearances")]
	public float  seenEverySeconds;
	private float currentSpeed;
	private GameObject currentTarget;
	private Defenders def;
	private Animator anim;

	// Use this for initialization
	void Start () {
		def = GetComponent<Defenders>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		if(!currentTarget){
			anim.SetBool("isAttacking",false);
			//att.Attack(obj);
		}
	}
	
	void OnTriggerEnter2D(){
		Debug.Log(name + " trigger enter");
	}
	
	public void SetSpeed (float speed){
		currentSpeed = speed;
	}
	
	//called from the animator at the time of actual attack
	public void StrikeCurrentTarget(float damage){
		if(currentTarget){
			Health health = currentTarget.GetComponent<Health>();
			if(health){
				health.DealDamage(damage);
			}
		}
		
		
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;	
	}
	
}
