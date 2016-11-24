using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour,IGvrGazeResponder {



	private bool isGazing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (isGazing) {
			Invoke ("LoadScene", 0.8f);
		}
	}


	public void OnGazeEnter(){
		isGazing = true;
	}

	public void OnGazeExit(){
		isGazing = false;
	}

	public void OnGazeTrigger(){

	}

	public void LoadScene(){
		if (isGazing) {
			SceneManager.LoadScene ("main game");
		}
	}

}
