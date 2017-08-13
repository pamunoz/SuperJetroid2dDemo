using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3, 5);
	public bool standing;
	public float jetSpeed = 15f;
	public float airSpeedMultiplier = .3f;

	// Reference to the Animator
	private Animator animator;
	private Rigidbody2D rigidBody2D;
	private PlayerController controller;

	void Start() {
		rigidBody2D = GetComponent<Rigidbody2D> ();
		controller = GetComponent<PlayerController> ();
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		float forceX = 0f;
		float forceY = 0f;

		// Animations states
		int walkingAnimation = 1;
		int idleAnimation = 0;
		int flyingAnimation = 2;
		int fallingAnimation = 3;

		float absVelX = Mathf.Abs (rigidBody2D.velocity.x);
		float absVelY = Mathf.Abs (rigidBody2D.velocity.y);

		if (absVelY < .2f) {
			standing = true;
		} else {
			standing = false;
		}

		// We set condition testing wheter the player is moving left or right
		if (controller.moving.x != 0) {
			if (absVelX < maxVelocity.x) {
				// Movint player left or right
				forceX = standing ? 
					speed * controller.moving.x : 
					(speed * controller.moving.x * airSpeedMultiplier);

				// Moving the player left or right depending on the direction
				int leftOrRight = forceX > 0 ? 1 : -1;
				transform.localScale = new Vector3 (leftOrRight, 1, 1);
			}
			// We set the integer that represent the AnimState to 1 or 0 base on what
			// the Player is doing
			// this mean if the player is movient left or right
			// we want it to be in the walking state   
			animator.SetInteger ("AnimState", walkingAnimation);
		} else {
			// If the Player is not movien left or right we want in to be in 
			// idle
			animator.SetInteger ("AnimState", idleAnimation);
		}

		// We we controll the flying states
		if (controller.moving.y > 0) {
			if(absVelY < maxVelocity.y)
				forceY = jetSpeed * controller.moving.y;

			// if the player is moving up, we want it to have an flying animation
			animator.SetInteger ("AnimState", flyingAnimation);
		} else if (absVelY > 0){
			// We set the animation to falling
			animator.SetInteger ("AnimState", fallingAnimation);
		}

		rigidBody2D.AddForce (new Vector2 (forceX, forceY));
	}
}