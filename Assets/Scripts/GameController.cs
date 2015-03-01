using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject roomObj;
	public GameObject lights;
	public GameObject player;
	public GameObject bullet;
	public GameObject enemy;

	void Awake() {
		//Transform room = roomObj.transform;
		Instantiate (roomObj, new Vector3 (0f, 0f, 0f), Quaternion.identity);
		Instantiate (lights, new Vector3 (0f, 0f, 0f), Quaternion.identity);
		Instantiate (player, new Vector3 (0f, 0.5f, 0f), Quaternion.identity);
		Instantiate (bullet, new Vector3 (2.77f, 0.5f, 3.27f), Quaternion.identity);
		Instantiate (enemy, new Vector3 (-3.05f, .51f, -3.82f), Quaternion.identity);
	}
}
