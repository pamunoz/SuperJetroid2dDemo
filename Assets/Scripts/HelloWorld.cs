﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class HelloWorld : MonoBehaviour {

	// for this case we use the type,instead of var
	public List<string> list = new List<string> ();
	public float speed = 2f;

	// Use this for initialization
	void Start () {
		list.Add ("Hello");
		list.Add ("World");

		print (list [0] + " " + list [1]);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);	
	
	}
}
