using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour {

	/* 
	  this will contain all the sprites
	  that we load from the Resources folder.
	 */
	public Sprite[] sprites;

	/* 
	  This is the name of the file that we use
	  to pull the texture out of the folder
	*/
	public string resourceName;
	/* value if we want to select the sprite
	  this is the id in our sprite array,
	  that if this is set, will override,
	  the random function */
	public int currentSprite = -1;

	// Use this for initialization
	void Start () {
		if (resourceName != "") {
			sprites = Resources.LoadAll<Sprite> (resourceName);

			if (currentSprite == -1)
				currentSprite = Random.Range (0, sprites.Length);
			else if (currentSprite > sprites.Length)
				// we avoid index out of bound exception
				currentSprite = sprites.Length - 1;

			// We pick randomly an sprite from the sprites array 
			GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
