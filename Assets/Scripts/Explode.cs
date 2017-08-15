using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	public BodyPart bodyPart;
	public int totalParts = 5;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {}
	// This method is trigger on the object colliding with another object
	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "Deadly") {
			OnExplode ();
		}
	}

	// This method is trigger on the object colliding with another object
	void OnCollisionEnter2D(Collision2D target) {
		if (target.gameObject.tag == "Deadly") {
			OnExplode ();
		}
	}

	void OnExplode() {
		// This will remove the player from the Scene
		Destroy (gameObject);
		
		// generate random body parts with random directions
		GenerateBodyParts ();
	}

	/* This methods generates body parts and apply forces to them in different directions */
	private void GenerateBodyParts() {
		

		var currentTransform = transform;

		for (int i = 0; i < totalParts; i++) {
			// this move the position of the body part to start outside of the player area
			currentTransform.TransformPoint (0, -100, 0);
			// then a new version of the body part is cloned from the prefab folder
			//Vector3 newPosition = currentTransform.position;
			//Quaternion zeroRotation = Quaternion.identity;
			BodyPart clone = new BodyPart();
			if (bodyPart != null) {
				clone = Instantiate (bodyPart, currentTransform.position, Quaternion.identity) as BodyPart;
			} else {
				Debug.Log ("This objects is null, what is happening!!!");
			}

			// We apply a force to the rigidbody
			Rigidbody2D currentRigidBody = clone.GetComponent<Rigidbody2D>();

			if (currentRigidBody != null) {
				// apply force going left or righ
				currentRigidBody.AddForce (Vector3.right * Random.Range (-50, 50));
				// apply force going up in a specific speed
				currentRigidBody.AddForce (Vector3.up * Random.Range (100, 400));				
			}

		}		
	}
}
