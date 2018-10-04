using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;
	public Score score;
	public void EndGame() {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			GameObject s = GameObject.FindGameObjectWithTag("Score");
			score = s.GetComponent<Score>();
			score.isFinished = true;
			completeLevelUI.SetActive(true);
		}
	}
	

	public void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
