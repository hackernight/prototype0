using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControl : MonoBehaviour {
	private Dictionary<KeyCode, Vector3> movementKeyMap = new Dictionary<KeyCode, Vector3>{
		{KeyCode.W, Vector3.forward},
		{KeyCode.A, Vector3.left},
		{KeyCode.S, Vector3.back},
		{KeyCode.D, Vector3.right},
	};

	public float speed = 2f;
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 deltaMove = Vector3.zero;
		foreach(var key in movementKeyMap) {
			if(Input.GetKey(key.Key)){
				deltaMove += key.Value;
			}
		}

		rigidbody.velocity = deltaMove * speed;
	}
	
}
