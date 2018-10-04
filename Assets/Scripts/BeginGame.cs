using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {

	// Use this for initialization
	public void LoadGame () {
		SceneManager.LoadScene("Level01");
	}
	
	// Update is called once per frame
}
