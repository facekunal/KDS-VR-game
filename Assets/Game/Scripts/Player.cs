using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	private int heartsCount;
	public Text heartsCountText;

	private AudioSource asrc;

	public AudioClip heartSound;

	// Use this for initialization
	void Start () {
		asrc = GetComponent<AudioSource>();
		asrc.volume = PlayerPrefs.GetFloat ("volume");


		heartsCount = 0;
		heartsCountText.text = heartsCount.ToString ();
	}

	// Update is called once per frame
	void Update () {

	}

	//if player touches any heart then destroy that heart
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("heart")){
			Destroy (other.gameObject);

			//play sound
			AudioSource.PlayClipAtPoint (heartSound,Camera.main.transform.position);

			heartsCount++;
			//increase health by 25
			if (Health.health <= 80) {
				Health.health += 20;
			} else {
				Health.health = 100;
			}
			heartsCountText.text = heartsCount.ToString ();
		}
	}
}
