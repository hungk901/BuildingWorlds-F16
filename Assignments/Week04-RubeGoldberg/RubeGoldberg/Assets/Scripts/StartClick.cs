using UnityEngine;
using System.Collections;

public class StartClick : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown ("space")) {
			this.GetComponent<Rigidbody> ().useGravity = true;
		}
	}
}
