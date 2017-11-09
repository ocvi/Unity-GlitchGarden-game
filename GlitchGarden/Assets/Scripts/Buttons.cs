using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {
	
	public GameObject defenderPrefab;
	public static GameObject selectedDefender;
	private Button[] buttonArray;
	private Text costText;
	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button>();
		costText = GetComponentInChildren<Text>();
		if(!costText){
			Debug.LogWarning(name + "No cost text");
		}
		costText.text = defenderPrefab.GetComponent<Defenders>().starCost.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		print (name + "pressed");
		
		foreach (Button thisButton in buttonArray){
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
		
	}
}
