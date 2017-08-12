using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2 (3, 5);

	Rigidbody2D rigidbody2D;

	void Start() {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}

	
	// Update is called once per frame
	void Update () {
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);

		if (Input.GetKey ("right")) {
			if (absVelX < maxVelocity.x)
				forceX = speed;

			// We want to flip the player left to right
			transform.localScale = new Vector3(1, 1, 1);
			
		} else if (Input.GetKey ("left")) {
			if (absVelX < maxVelocity.x)
				forceX = -speed;

			// We want to flip the player left to right
			transform.localScale = new Vector3(-1, 1, 1);
		}

		rigidbody2D.AddForce (new Vector2 (forceX, forceY));
	}
}
