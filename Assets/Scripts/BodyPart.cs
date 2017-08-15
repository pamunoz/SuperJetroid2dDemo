using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour {

	private SpriteRenderer mSpriteRenderer;
	private Color mColorStart;
	private Color mColorEnd;
	private float mTime = 0.0f;

	// Use this for initialization
	void Start () {
		mSpriteRenderer = GetComponent<SpriteRenderer> ();
		mColorStart = mSpriteRenderer.color;
		float alpha = 0.0f;
		mColorEnd = new Color (mColorStart.r, mColorStart.g, mColorStart.b, alpha);
	}
	
	// Update is called once per frame
	void Update () {
		FadesOutBodyPart ();		
	}

	/* 
	 * This methods will make the body part fades out and destroy itself
	 */
	private void FadesOutBodyPart() {
		// We gonna change the material clor over time
		mTime += Time.deltaTime;
		// Lerp interpolate over two values over a fraction of time
		mSpriteRenderer.material.color = Color.Lerp (mColorStart, mColorEnd, mTime / 2);
		// alpha is let than cero
		float currentAlpha = mSpriteRenderer.material.color.a;
		// if the body part is transparent, it destroy itself
		if (currentAlpha <= 0.0) {
			Destroy (gameObject);
		}
	}
}
