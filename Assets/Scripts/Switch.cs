using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target) {
		int switchDown = 1;
		animator.SetInteger ("AnimState", switchDown);		
	}

	void OnTriggerExit2D(Collider2D target) {
		int switchUp = 2;
		animator.SetInteger ("AnimState", switchUp);
	}
}
