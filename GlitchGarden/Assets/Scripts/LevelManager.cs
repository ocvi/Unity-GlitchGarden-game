using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float loadingTime;
	
	void Start(){
		if(loadingTime <= 0){
			Debug.Log("Loading time disabled");
		}else{
			Invoke ("LoadNextLevel",loadingTime);
			}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel(){
	Application.LoadLevel(Application.loadedLevel + 1);
	}

}
