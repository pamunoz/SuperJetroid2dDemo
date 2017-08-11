using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// if the type is ovious is better to use var, instead of the type;
		var name = "Pablo Munoz";
		var age = 33;
		var speed = 4.3f;
		var likesGames = true;

		var stringArray = new string[2];
		stringArray[0] = "Hello";
		stringArray[1] = "World";

		var phrase = stringArray [0] + " " + stringArray [1];

		// for showing something in the console we can use Debug.Log
		Debug.Log(phrase);
		// Or we can use pring
		print(name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
