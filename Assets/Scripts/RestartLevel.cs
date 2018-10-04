using UnityEngine;

public class RestartLevel : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	public void Restarts () {
		FindObjectOfType<GameManager>().Restart();
	}
}
