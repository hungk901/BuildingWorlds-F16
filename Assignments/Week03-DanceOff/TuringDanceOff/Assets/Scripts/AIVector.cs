using UnityEngine;
using System.Collections;

public class AIVector : MonoBehaviour {

	float lastTimeWhenIMove = 0f;
	public float randomAngle = 0f;
	public bool isStartMoving = false;

	void Update () {
		isStartMoving = false;

		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (Random.Range (-2, 0), 0, 0);
			isStartMoving = true;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (Random.Range (2, 0), 0, 0);
			isStartMoving = true;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (0, 0, Random.Range (-2, 0));
			isStartMoving = true;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (0, 0, Random.Range (2, 0));
			isStartMoving = true;
		}

		if (isStartMoving) {
			if (Time.time > lastTimeWhenIMove + Random.Range (0, 1f)) {
				randomAngle = Random.Range (-4f, 4f) * 3.5f;

				lastTimeWhenIMove = Time.time;
			}
		}
		else {
			randomAngle = 0;
		}
		transform.Rotate (0, randomAngle, 0);
	}
}
