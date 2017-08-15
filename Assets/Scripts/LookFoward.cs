using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookFoward : MonoBehaviour {
	// the begin loking, and when it ends
	public Transform sightStart, sightEnds;
	// wheter there is a collition or not
	private bool mCollision = false;
	public bool needsCollision = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		DrawLineOfSight ();
		
		if (mCollision  == needsCollision)
			TurnAround ();

	}

	private void TurnAround() {
		int left = -1;
		int right = 1;
		this.transform.localScale = new Vector3 ((transform.localScale.x == right) ? left : right, 1, 1);			
	}

	private void DrawLineOfSight() {
		// Linecast allow us to project a line of sight, and see
		// if it collide with anything, in this case, a layer called "Solid"
		mCollision = Physics2D.Linecast (sightStart.position, sightEnds.position, 1 << LayerMask.NameToLayer ("Solid"));
		// Lines to se on the Editor for debuging
		Debug.DrawLine (sightStart.position, sightEnds.position, Color.green);		
	}
}
