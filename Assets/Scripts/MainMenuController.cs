using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

	public SpawnManager spawner; 
	public void LoadLevelEasy() {
		GameObject s = GameObject.FindGameObjectWithTag("Spawner");
		spawner = s.GetComponent<SpawnManager>();
		spawner.obsDist = 70f;
	}

	public void LoadLevelMedium() {
		GameObject s = GameObject.FindGameObjectWithTag("Spawner");
		spawner = s.GetComponent<SpawnManager>();
		spawner.obsDist = 40f;
	}

	public void LoadLevelHard() {
		GameObject s = GameObject.FindGameObjectWithTag("Spawner");
		spawner = s.GetComponent<SpawnManager>();
		spawner.obsDist = 20f;
	}
}
