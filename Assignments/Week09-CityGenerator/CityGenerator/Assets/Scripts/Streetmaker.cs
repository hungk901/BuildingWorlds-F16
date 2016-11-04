using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Streetmaker : MonoBehaviour {

	BuildingChecker myBuildingChecker;
	int _numOfBuildings;
	int numOfBuildingsMax = 750;
//	public GameObject myStreetmakerPrefab;
//	public GameObject myBuildingPrefab01;
//	public GameObject myBuildingPrefab02;
//	GameObject tmpPrefab01;
//	GameObject tmpPrefab02;
	public Transform myStreetmakerPrefab;
	public Transform myBuildingPrefab01;
	public Transform myBuildingPrefab02;
	Transform tmpPrefab01;
	Transform tmpPrefab02;
	int stepCount = 0;
	int stepCountMax = 0;


	void Start () {
		stepCountMax = (int)Random.Range (15f, 20f);
	}

	void Update () {
		_numOfBuildings = GameObject.Find ("BuildingCheck").GetComponent<BuildingChecker>().numOfBuildings;
//		Debug.Log (_numOfBuildings);

		if (_numOfBuildings < numOfBuildingsMax) {
			transform.position += transform.forward * 5f;

			tmpPrefab01 = RandomBuilding ();
			tmpPrefab02 = RandomBuilding ();
			float randomNumTmp1 = Random.Range (0f, 100f);

			if (randomNumTmp1 < 85f) {
//				GameObject leftBuilding = (GameObject)Instantiate (tmpPrefab01, transform.position - transform.right * 5f, transform.rotation);
//				leftBuilding.transform.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
//				leftBuilding.transform.position = new Vector3 (leftBuilding.transform.position.x, 0, leftBuilding.transform.position.z);
//				leftBuilding.GetComponent<Renderer> ().material.color = Random.ColorHSV ();
				Transform leftBuilding = (Transform)Instantiate (tmpPrefab01, transform.position - transform.right * 5f, transform.rotation);
				leftBuilding.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
				leftBuilding.position = new Vector3 (leftBuilding.transform.position.x, 0, leftBuilding.transform.position.z);
				leftBuilding.GetComponent<Renderer> ().material.color = Random.ColorHSV ();

//				GameObject rightBuilding = (GameObject)Instantiate (tmpPrefab02, transform.position + transform.right * 5f, transform.rotation);
//				rightBuilding.transform.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
//				rightBuilding.transform.position = new Vector3 (rightBuilding.transform.position.x, 0, rightBuilding.transform.position.z);
//				rightBuilding.GetComponent<Renderer> ().material.color = Random.ColorHSV ();
				Transform rightBuilding = (Transform)Instantiate (tmpPrefab02, transform.position + transform.right * 5f, transform.rotation);
				rightBuilding.localScale = new Vector3 (.9f, Random.Range (.5f, 4.5f), .9f);
				rightBuilding.position = new Vector3 (rightBuilding.transform.position.x, 0, rightBuilding.transform.position.z);
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

			if (stepCount >= stepCountMax) {
				DestroyObject (this.gameObject);
			}
		}
	}

//	GameObject RandomBuilding () {
//		float randomNumForBuilding = Random.Range (0f, 100f);
//		GameObject _tmpPrefab;
//
//		if (randomNumForBuilding > 30f) {
//			_tmpPrefab = myBuildingPrefab01;
//		} else {
//			_tmpPrefab = myBuildingPrefab02;
//		}
//		return _tmpPrefab;
//	}

	Transform RandomBuilding () {
		float randomNumForBuilding = Random.Range (0f, 100f);
		Transform _tmpPrefab;

		if (randomNumForBuilding > 30f) {
			_tmpPrefab = myBuildingPrefab01;
		} else {
			_tmpPrefab = myBuildingPrefab02;
		}
		return _tmpPrefab;
	}

}