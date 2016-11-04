using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Streetmaker : MonoBehaviour {

	public GameObject myStreetmakerPrefab;
	public GameObject myBuildingPrefab01;
	public GameObject myBuildingPrefab02;
	GameObject tmpPrefab01;
	GameObject tmpPrefab02;
	public int stepCount = 0;
	public int stepCountMax = 0;

	void Start () {
		stepCountMax = (int)Random.Range (15f, 25f);
	}

	void Update () {
		transform.position = transform.position + transform.forward * 5f;

		tmpPrefab01 = RandomBuilding ();
		tmpPrefab02 = RandomBuilding ();
		float randomNumTmp1 = Random.Range (0f, 100f);

		if (randomNumTmp1 < 85f) {

			GameObject leftBuilding = (GameObject)Instantiate (tmpPrefab01, transform.position - transform.right * 5f, transform.rotation);
			leftBuilding.transform.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
			leftBuilding.transform.position = new Vector3 (leftBuilding.transform.position.x, 0, leftBuilding.transform.position.z);
			leftBuilding.GetComponent<Renderer> ().material.color = Random.ColorHSV ();

			GameObject rightBuilding = (GameObject)Instantiate (tmpPrefab02, transform.position + transform.right * 5f, transform.rotation);
			rightBuilding.transform.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
			rightBuilding.transform.position = new Vector3 (rightBuilding.transform.position.x, 0, rightBuilding.transform.position.z);
			rightBuilding.GetComponent<Renderer> ().material.color = Random.ColorHSV ();
		} else {
			float randomNumTmp2 = Random.Range (0f, 100f);

			if (randomNumTmp2 < 50f) {
				Instantiate (myStreetmakerPrefab, transform.position, Quaternion.Euler (0, transform.eulerAngles.y - 90, 0));
			} else {
				Instantiate (myStreetmakerPrefab, transform.position, Quaternion.Euler (0, transform.eulerAngles.y + 90, 0));
			}
		}
		stepCount++;

		if (stepCount > stepCountMax) {
			DestroyObject (this.gameObject);
		}
	}

	GameObject RandomBuilding () {
		float randomNumForBuilding = Random.Range (0f, 100f);
		GameObject _tmpPrefab;

		if (randomNumForBuilding > 30f) {
			_tmpPrefab = myBuildingPrefab01;
		} else {
			_tmpPrefab = myBuildingPrefab02;
		}
		return _tmpPrefab;
	}

}