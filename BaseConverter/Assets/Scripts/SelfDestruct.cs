using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {


	public float timeToDestroy;
	void Start () {
		
	}
	

	void Update () {
		if (timeToDestroy <= 0) {
			Destroy (gameObject);
		} else {
			timeToDestroy -= Time.deltaTime;
		}

	}
}
