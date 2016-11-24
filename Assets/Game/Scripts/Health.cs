using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public static int health;

	public Text healthText;

	//public Text highScore;



	// Use this for initialization
	void Start () {
		health = 100;


		healthText.text = health.ToString ()+" +";
		//highScore.text = PlayerPrefs.GetInt ("score").ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		healthText.text = health.ToString ()+" +";

		//check if player is dead
		if (health < 1) {
			EndGame ();
		}
	}

	void EndGame(){
		//save the highscore
		//PlayerPrefs.SetInt ("score",Score.score);

		if (PlayerPrefs.GetInt ("score") <= Score.score) {
			PlayerPrefs.SetInt ("score",Score.score);
		}

		//switch to menu
		SceneManager.LoadScene ("menu test");

	}
}
