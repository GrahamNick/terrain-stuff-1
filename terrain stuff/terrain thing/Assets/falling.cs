using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour {

	private Vector3 startpos;

	void Start() {
		startpos = transform.position;
		if (transform.position.y < -10) {
			transform.position = startpos;
		}
	}
}

