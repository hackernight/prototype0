using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
	public Vector3 velocity = new Vector3(1f,0f,0f);
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += velocity * speed;
	}
}
