using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	Rigidbody playRigibody;
	float moveSpeed = 7.5f;

	void Start () {
		playRigibody = GetComponent<Rigidbody> ();
		transform.position = new Vector3 (Random.Range (-20f, 20f), 0, Random.Range (-20f, 20f));
	}
	
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.forward * Time.deltaTime;
			playRigibody.velocity = transform.forward * moveSpeed;
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += -transform.forward * Time.deltaTime;
			playRigibody.velocity = -transform.forward * moveSpeed;
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += -transform.right * Time.deltaTime;
			playRigibody.velocity = -transform.right * moveSpeed;
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += transform.right * Time.deltaTime;
			playRigibody.velocity = transform.right * moveSpeed;
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
//		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.RightArrow)) {
//			transform.rotation = Quaternion.Euler (0, 45f, 0);
//		}
//		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.LeftArrow)) {
//			transform.rotation = Quaternion.Euler (0, -45f, 0);
//		}
//		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.LeftArrow)) {
//			transform.rotation = Quaternion.Euler (0, 135f, 0);
//		}
//		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightArrow)) {
//			transform.rotation = Quaternion.Euler (0, -135f, 0);
//		}
	}

}
