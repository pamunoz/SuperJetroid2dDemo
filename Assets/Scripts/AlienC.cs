using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienC : MonoBehaviour {

	public float attackDelay = 3f;

	private Animator mAnimator;

	// Use this for initialization
	void Start () {
		Debug.Log ("Start...");
		mAnimator = GetComponent<Animator> ();

		// if the attack delay is 0 or less, the alien wont attack
		if (attackDelay > 0) {
			StartCoroutine (OnAttack());			
		}
	}
	
	// Update is called once per frame
	void Update () {
		int idle = 0;
		mAnimator.SetInteger ("AnimState", idle);		
	}

	IEnumerator OnAttack() {
		Debug.Log ("OnAttack...");
		yield return new WaitForSeconds (attackDelay);
		Fire ();
		StartCoroutine (OnAttack ());
	}

	void Fire() {
		Debug.Log ("Fire...");
		int attack = 1;
		// Change the animation to the attack state
		mAnimator.SetInteger ("AnimState", attack);
	}
}
