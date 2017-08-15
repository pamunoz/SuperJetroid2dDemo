using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// This will allow us to follow any game object we set to it.
	public GameObject target;

	// Reference to the camera
	private Camera mCamera;

	void Awake() {
		// this is to set the camera 
		// to pixel perfect size
		float pixelRatio = 100f;
		mCamera = GetComponent<Camera>();
		mCamera.orthographicSize = ((Screen.height / 2.0f) / pixelRatio);
	}

	/*
	 * For the camera, which updates constantly in every frame,
	 * it's easy to catch a reference to this transform,
	 * so we don't have a performance hit.
	 */ 
	private Transform _t;

	// Use this for initialization
	void Start () {
		_t = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		// Set the camera's position, to the target position
		// while maintaining the camera z index
		transform.position = new Vector3(_t.position.x, _t.position.y, transform.position.z);
		
	}
}
