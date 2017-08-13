using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public const int IDLE = 0;
	public const int OPENING = 1;
	public const int OPEN = 2; 
	public const int CLOSING = 3;
	public float closeDelay = 0.5f;
	// idle is the default state of the door
	private int mState = IDLE;

	private Animator mAnimator;
	private Collider2D mCollider2D;

	// Use this for initialization
	void Start () {
		mAnimator = GetComponent<Animator> ();
		mCollider2D = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// These methods will track the door state
	void OnOpenStart() {
		mState = OPENING;
	}

	void OnOpenEnd() {
		mState = OPEN;
	}

	void OnCloseStart() {
		mState = CLOSING;
	}

	void OnCloseEnd() {
		mState = IDLE;
	}

	// These methods handle turning on and off the box collider for the door
	void DisableCollider2D() {
		mCollider2D.enabled = false;
	}

	void EnableCollider2D() {
		mCollider2D.enabled = true;
	}

	// These methods handle the public properties of the class
	// Allowing us to open and close the door.
	public void Open() {
		mAnimator.SetInteger ("AnimState", 1);
	}

	public void Close() {
		// Here we want the door closing with a delay
		// calling a method in a separate thread
		StartCoroutine (CloseNow());
	}

	private IEnumerator CloseNow() {
		yield return new WaitForSeconds (closeDelay);
		mAnimator.SetInteger ("AnimState", 2);
	}
}
