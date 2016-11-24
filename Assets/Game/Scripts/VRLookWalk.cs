using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VRLookWalk : MonoBehaviour {

	//Main camera
	public Transform vrCamera;

	//Minimum angle at which walking will be triggered
	public float toggleAngle = 30.0f;

	//walking speed
	public float speed = 3.0f;

	//move forward or stay
	public bool moveForward;

	public bool exit = false;

	//character controlle inbuilt script attached to the main camera
	private CharacterController cc;

	// Use this for initialization
	void Start () {
		
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		//check if head is moved >= toggle angle
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
			moveForward = true;
		} else {
			moveForward = false;
		}

		if (vrCamera.eulerAngles.z >= toggleAngle+10.0f && vrCamera.eulerAngles.z < 90.0f) {
			exit = true;
		} 

		//if move forward if true, move the character
		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}

		if (exit) {
			//move to menu
			SceneManager.LoadScene ("menu test");
		}
	}

}
