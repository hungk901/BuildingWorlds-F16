using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildingCounter : MonoBehaviour {

	public int numOfBuildings = 0;
	public List<GameObject> allBuildingPrefabs = new List<GameObject>();
	public GameObject _myStreetmakerPrefab;


	void Update () {
		allBuildingPrefabs.Clear ();
		_myStreetmakerPrefab = GameObject.Find ("StreetmakerPrefab");
		allBuildingPrefabs.AddRange (GameObject.FindGameObjectsWithTag ("Building"));
		numOfBuildings = allBuildingPrefabs.Count;

		if (_myStreetmakerPrefab == null) {
			if (allBuildingPrefabs.Count != 0) {
				for (int i = 0; i < allBuildingPrefabs.Count; i++) {
					for (int j = 0; j < allBuildingPrefabs.Count; j++) {
						if (i != j) {
							if (allBuildingPrefabs [i] != null && allBuildingPrefabs [j] != null) {
								Vector3 diff = allBuildingPrefabs [i].transform.position - allBuildingPrefabs [j].transform.position;

								if (Mathf.Abs (diff.x) < .1f && Mathf.Abs (diff.z) < .1f) {
									Destroy (allBuildingPrefabs [j].gameObject);
									allBuildingPrefabs.RemoveAt (j);
//								Debug.Log (i + " , " + j);
								}
							}
						}
					}
				}
			}
		}
	}
}
