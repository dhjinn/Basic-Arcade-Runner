using UnityEngine;
using UnityEngine.UI;

public class FetchScore : MonoBehaviour {
	
	public Score finalScore;
	public Text finalScoreText;
	// Use this for initialization
	public void Start () {
		GameObject s = GameObject.FindGameObjectWithTag("Score");
		finalScore = s.GetComponent<Score>();
		finalScoreText.text = finalScore.score.ToString("0");
	}
	
	// Update is called once per frame
}
