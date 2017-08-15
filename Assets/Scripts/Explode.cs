using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// This method is trigger on the object colliding with another object
	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Deadly") {
			OnExplode ();
		}
	}

	void OnExplode() {
		// This will remove the player from the Scene
		Destroy (gameObject);
	}
}
