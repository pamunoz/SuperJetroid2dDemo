using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour {

	public float speed = 0.5f;
	private Rigidbody2D mRigidbody2d;

	// Use this for initialization
	void Start () {
		mRigidbody2d = GetComponent<Rigidbody2D> ();		
	}
	
	// Update is called once per frame
	void Update () {
		// this is for facing in left or righ at the fixed speed
		mRigidbody2d.velocity = new Vector2 (transform.localScale.x, 0) * speed;		
	}
}
