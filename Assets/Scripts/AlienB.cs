using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienB : MonoBehaviour {

	private Animator mAnimator;

	// Use this for initialization
	void Start () {
		mAnimator = GetComponent<Animator> ();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// if something collide with this
	// it will atack
	void OnTriggerEnter2D(Collider2D target) {
		mAnimator.SetInteger ("AnimState", 1);
	}
}
