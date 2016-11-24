using UnityEngine;
using System.Collections;

public class VRMode : MonoBehaviour,IGvrGazeResponder {

	private bool isGazing = false;

	void ToggleVRMode() {
		if (isGazing) {
			GvrViewer.Instance.VRModeEnabled = !GvrViewer.Instance.VRModeEnabled;
			isGazing = false;

			if (PlayerPrefs.GetInt ("VRMode") == 0)
				PlayerPrefs.SetInt ("VRMode", 1);
			else
				PlayerPrefs.SetInt ("VRMode", 0);
		}
	}
		

	// Use this for initialization
	void Start () {
		/*
		if (GvrViewer.Instance.VRModeEnabled)
			PlayerPrefs.SetInt ("VRMode", 1);
		else
			PlayerPrefs.SetInt ("VRMode", 0);
			*/

		if (PlayerPrefs.GetInt ("VRMode") == 1) {
			GvrViewer.Instance.VRModeEnabled = true;
		} else
			GvrViewer.Instance.VRModeEnabled = false;
	}

	// Update is called once per frame
	void Update () {

		if (isGazing) {
			Invoke ("ToggleVRMode", 0.8f);
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
