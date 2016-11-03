using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour {

	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (0);
		}	
	}
}
