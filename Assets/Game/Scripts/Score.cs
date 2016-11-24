using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//score of the player
	public static int score;

	public static int level;

	public Text scoreText;




	// Use this for initialization
	void Start () {
		level = 0;
		score = 0;


		scoreText.text = "Score: "+ Score.score.ToString ();

	}

	void Update(){
		Debug.Log ("score : "+ score);
		level = score % 10;

		scoreText.text = "Score: "+ Score.score.ToString ();
		if (PlayerPrefs.GetInt ("score") <= Score.score) {
			PlayerPrefs.SetInt ("score",Score.score);
		}
	}

}
