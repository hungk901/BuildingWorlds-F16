using UnityEngine;
using System.Collections;

public class ClickingChecker : MonoBehaviour {

	GameObject[] myAutoRobots;
	string[] _theClickedRobotTag;
	int[] _timesBeClicked;
	public int totalTimesClicked;

	void Start () {
		myAutoRobots = GameObject.FindGameObjectsWithTag ("AutoRobots");
		_theClickedRobotTag = new string[myAutoRobots.Length];
		_timesBeClicked = new int[myAutoRobots.Length];
	}
	
	// Update is called once per frame
	void Update () {
		totalTimesClicked = 0;

		for (int i = 0; i < myAutoRobots.Length; i++) {
			_theClickedRobotTag [i] = myAutoRobots [i].GetComponent<MouseDownDetector> ().theClickedRobotTag;
			_timesBeClicked [i] = myAutoRobots [i].GetComponent<MouseDownDetector> ().timesBeClicked;
			totalTimesClicked += _timesBeClicked [i];

		}

		Debug.Log (totalTimesClicked);
	}
}
