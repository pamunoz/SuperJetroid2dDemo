﻿using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public Door door;
	public bool ignoreTrigger;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (ignoreTrigger)
			return;

		if (target.gameObject.tag == "Player") {
			door.Open();
		}
	}

	void OnTriggerExit2D(Collider2D target){
		if (ignoreTrigger)
			return;

		if (target.gameObject.tag == "Player") {
			door.Close();
		}
	}

	public void Toggle(bool value) {
		if (value)
			door.Open ();
		else
			door.Close ();
	}

	void OnDrawGizmos() {
		Gizmos.color = ignoreTrigger ? Color.gray : Color.green;

		// WE get a reference to the box collider2d so we
		// can calculate the size of the box to draw around the door
		var bc2d = GetComponent<BoxCollider2D>();
		var bc2dPos = bc2d.transform.position;
		var newPos = new Vector2 (bc2dPos.x + bc2d.offset.x, bc2dPos.y + bc2d.offset.y);

		// draw the box around the door
		Gizmos.DrawWireCube (newPos, new Vector2 (bc2d.size.x, bc2d.size.y));
	}
}
