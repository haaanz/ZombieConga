using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float speed = -1;

	private Transform spawnPoint;
	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
		spawnPoint = GameObject.Find ("spawnpoint").transform;
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{
		if (mainCamera != null) {
			float yMax = mainCamera.orthographicSize - 0.5f;
			transform.position = new Vector3 (spawnPoint.position.x, 
		                                 Random.Range (-yMax, yMax), 
		                                 transform.position.z);
		}
	}
}
