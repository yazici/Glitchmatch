﻿using UnityEngine;
using System.Collections;

public class LetMeLive : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (WaitAndDie (3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator WaitAndDie(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		Destroy (gameObject);
	}
}
