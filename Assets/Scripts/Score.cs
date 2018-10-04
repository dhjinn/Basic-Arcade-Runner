using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public bool isFinished = false;
	public Transform player;
	public Text scoreText;
	public float score;
	public float pointIncreasePerSecond = 10f;


	// Update is called once per frame
	void Update () {
		if (!isFinished) {
			score += pointIncreasePerSecond * Time.deltaTime;
			scoreText.text = score.ToString("0"); 
		}
	}
}
