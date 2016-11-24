using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

	public Text highScore;

	// Use this for initialization
	void Start () {
		highScore.text = PlayerPrefs.GetInt ("score").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}




}
