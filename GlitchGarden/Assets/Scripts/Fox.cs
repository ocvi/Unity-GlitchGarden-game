using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attackers))]

public class Fox : MonoBehaviour {
	private Animator anim;
	private Attackers att;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		att = GetComponent<Attackers>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		
		GameObject obj = collider.gameObject;
		//abort if not colliding with defender
		if(!obj.GetComponent<Defenders>()){
			return;
		}	
		
		if(obj.GetComponent<Gravestone>()){
			anim.SetTrigger("jumpTrigger");
		}else{
			anim.SetBool("isAttacking",true);
			att.Attack(obj);
		}
	}
}
