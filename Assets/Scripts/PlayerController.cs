using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Vector2 moving = new Vector2 ();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// We want to clear the moving values on each update
		moving.x = moving.y = 0;

		// moving left or rigth
		if (Input.GetKey("right")) {
			moving.x = 1;			
		} else if(Input.GetKey ("left")) {
			moving.x = -1;			
		}

		// moving up or down
		if (Input.GetKey("up")) {
			moving.y = 1;			
		} else if(Input.GetKey ("down")) {
			moving.y = -1;			
		}
	}
}
