using UnityEngine;
using System.Collections;

public class BackgroundRepeater : MonoBehaviour {

	private Transform mainCameraTransform;
	private float spriteWidth;

	// Use this for initialization
	void Start () {
		mainCameraTransform = Camera.main.transform;
		spriteWidth = GetComponent<SpriteRenderer> ().bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x + spriteWidth < mainCameraTransform.position.x) {
			Vector3 newPos = transform.position;
			newPos.x += 2.0f * spriteWidth; 
			transform.position = newPos;
		}
	}
}
