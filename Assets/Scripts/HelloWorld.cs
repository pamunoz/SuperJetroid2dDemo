<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour {

	public List<string> list = new List<string>();
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class HelloWorld : MonoBehaviour {

	// for this case we use the type,instead of var
	public List<string> list = new List<string> ();
>>>>>>> 1caab0d3813b6522b02840e3af59e129bc8b50b4
	public float speed = 2f;

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
=======
		list.Add ("Hello");
		list.Add ("World");

>>>>>>> 1caab0d3813b6522b02840e3af59e129bc8b50b4
		print (list [0] + " " + list [1]);
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);
=======
		transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);	
	
>>>>>>> 1caab0d3813b6522b02840e3af59e129bc8b50b4
	}
}
