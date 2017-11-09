using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float secondsToFade;
	private Image fadePanel;
	private Color currentColor= Color.black;
	
	void Start(){
		fadePanel = GetComponent<Image>();
	}
	
	void Update(){
		if(Time.timeSinceLevelLoad < secondsToFade){
			//Fade IN
			float alphaChange = Time.deltaTime / secondsToFade;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		}else{
			gameObject.SetActive(false);
		}
	}
	
	
	
	
}
