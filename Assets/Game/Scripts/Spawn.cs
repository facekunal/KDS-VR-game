using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	private int count;

	// Use this for initialization
	void Start () {

		count = 0;

		Debug.Log ("hello");

		VRMode ();
		//GameObject.Find ("Map").SetActive (true);

		//set spawnpoint
		Instantiate (Resources.Load (Enemy.enemyName), new Vector3(74,24,16), new Quaternion());
		Instantiate (Resources.Load (Enemy.enemyName), new Vector3(74,24,16), new Quaternion());
		Instantiate (Resources.Load (Enemy.enemyName), new Vector3(74,24,16), new Quaternion());
		Instantiate (Resources.Load (Enemy.enemyName), new Vector3(74,2416), new Quaternion());
	}

	void VRMode() {

		if (PlayerPrefs.GetInt ("VRMode") == 0)
			GvrViewer.Instance.VRModeEnabled = false;
		else
			GvrViewer.Instance.VRModeEnabled = true;
	
	}
	// Update is called once per frame
	void Update () {
	

	}

	void FixedUpdate(){
		count++;


		if (count > 600) {
			count = 0;
			//spawn heart
			Vector3 v= new Vector3 (Random.Range (71f,94f),24,Random.Range (-21f,56f));
			 Instantiate (Resources.Load ("Heart"),v, new Quaternion());

		}
	}



}
