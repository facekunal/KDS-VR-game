using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class VRslider : MonoBehaviour {

	public float fillTime = 2f;
	private Slider myslider;
	private float timer;
	private bool gazedAt;
	private Coroutine fillBarRoutine;

	// Use this for initialization
	void Start () {
		myslider = GetComponent<Slider> ();
		if (myslider == null)
			Debug.Log ("Please add a slider componenet to this gameobject ");

		myslider.value = PlayerPrefs.GetFloat ("volume");
		PlayerPrefs.SetFloat("volume",myslider.value);
	}

	// Update is called once per frame
	void Update () {

	}
	public void PointerEnter(){
		gazedAt = true;
		fillBarRoutine = StartCoroutine (FillBar ());
	}
	public void PointerExit(){
		gazedAt = false;
		if (fillBarRoutine != null) {
			StopCoroutine (fillBarRoutine);
		}

		//save volume
		PlayerPrefs.SetFloat("volume",myslider.value);
	}

	private IEnumerator FillBar(){
		timer = 0f;
		while (timer < fillTime) {
			timer += Time.deltaTime;
			myslider.value = timer / fillTime;
			yield return null;
		}
	} 
}
