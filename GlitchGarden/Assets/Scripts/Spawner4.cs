using UnityEngine;
using System.Collections;

public class Spawner4 : MonoBehaviour {

	public GameObject[] attackerPrefabArray;
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject thisAttacker in attackerPrefabArray) {
			if(isTimeToSpawn(thisAttacker)){
				Spawn(thisAttacker);
			}
		}
	}
	void Spawn(GameObject myGameObject){
		GameObject myAttacker = Instantiate (myGameObject) as GameObject;
		myAttacker.transform.parent = transform;
		myAttacker.transform.position = transform.position;
	}
	
	
	bool isTimeToSpawn(GameObject attackerGameObject){
		Attackers attacker = attackerGameObject.GetComponent<Attackers>();
		float meanSpawnDelay= attacker.seenEverySeconds;
		float spawnsPerSecond= 1 / meanSpawnDelay;
		
		if (Time.deltaTime > meanSpawnDelay){
			Debug.LogWarning("Spawn rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime / 2 ;
		
		return (Random.value < threshold);
		
	}
}
