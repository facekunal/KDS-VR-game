using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public static string enemyName = "enemy";

	public float deathDistance=2f;
	public float distanceAway;

	public Transform thisObject;
	private Transform target;

	private NavMeshAgent navComponent;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		navComponent = this.gameObject.GetComponent <NavMeshAgent> ();

	}

	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (target.position, transform.position);

		if (target) {
			navComponent.SetDestination (target.position);
		} else {
			if (target == null) {

				target = this.gameObject.GetComponent<Transform> ();
			} else {
				target=GameObject.FindGameObjectWithTag ("MainCamera").transform;
			}
		}

		if (dist <= deathDistance) {
			//code to kill the player
			if(Health.health>0)
				Health.health-=1;
		}
	}
}
