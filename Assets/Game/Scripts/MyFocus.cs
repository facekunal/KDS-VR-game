/* This script is used to detect object on gaze. I have attached Gvr Gaze to the Main Camera.
 * Alternativly, one can use event triggers.
 */
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MyFocus : MonoBehaviour, IGvrGazeResponder {

	[SerializeField]
	private bool autoShoot = false;
	private bool isShooting = false;

	public AudioClip shootSound;


	void Start(){
		Debug.Log ("hello");
	}

	public void OnGazeEnter(){
		isShooting = true;
	}

	public void OnGazeExit(){
		isShooting = false;
	}

	public void OnGazeTrigger(){
		
	}

	public void ShootTarget(){
		if (isShooting) {
			AudioSource.PlayClipAtPoint (shootSound,Camera.main.transform.position);

			//update scores
			Score.score++;



			Debug.Log ("current score: "+Score.score);




			//reinitialize the enemy
			Vector3 v= new Vector3 (Random.Range (71f,94f),24,Random.Range (-21f,56f));

			Instantiate (Resources.Load (Enemy.enemyName),v , new Quaternion());

			if (Score.level > 8) {
				//one extra enemy
				Instantiate (Resources.Load (Enemy.enemyName),v , new Quaternion());
			}


			Destroy (gameObject);


		}
	}

	public void Update(){
		if (autoShoot && isShooting) {
			Invoke ("ShootTarget",0.5f);
		}

		Debug.Log ("hello");
	}

}
