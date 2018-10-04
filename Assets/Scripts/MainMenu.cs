using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Exit() {
		SceneManager.LoadScene("Title");
	}
}
