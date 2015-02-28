using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	private Transform target;
	private float speed = 1f;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 deltaMove = Vector3.zero;

		if (target.position.x - transform.position.x > float.Epsilon) {
			deltaMove.x = 1;
		}

		if (transform.position.x - target.position.x > float.Epsilon) {
			deltaMove.x = -1;
		}

		if (target.position.z - transform.position.z > float.Epsilon) {
			deltaMove.z = 1;
		}
		
		if (transform.position.z - target.position.z > float.Epsilon) {
			deltaMove.z = -1;
		}

		rigidbody.velocity = deltaMove * speed;
	}
}