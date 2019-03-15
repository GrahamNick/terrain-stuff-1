using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggered : MonoBehaviour {
	private int count = 0;
	public Text countText;
	public Text winText;
	private bool win;
	// Use this for initialization
	void Start () {
		countText.text = "You have collected " + count + "/3"; 
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= 3) {
			winText.text = "You have collected all of the things";
		}
		changeCount ();

	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive(false);
			count += 1;
		}
	}
	void changeCount() {
		countText.text = "You have collected " + count + "/3";
	}
}
