﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// This method is gonna return a collider 2d
	// that represent the target of the object that
	// set up the trigger
	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Player")
			Destroy (gameObject);		
	}
}
