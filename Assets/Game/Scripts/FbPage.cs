using UnityEngine;
using System.Collections;

public class FbPage : MonoBehaviour,IGvrGazeResponder {




	private bool isGazing = false;

	// Use this for initialization
	void Start () {

	}

	void OpenWebpage(){
		if(isGazing)
		Application.OpenURL ("http://www.google.com");
	}

	// Update is called once per frame
	void Update () {

		if (isGazing) {

			Invoke ("OpenWebpage", 0.8f);
		
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
		
}
