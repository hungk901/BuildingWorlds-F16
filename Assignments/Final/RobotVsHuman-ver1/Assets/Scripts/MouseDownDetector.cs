using UnityEngine;
using System.Collections;

public class MouseDownDetector : MonoBehaviour {

	public string theClickedRobotTag;
	public int timesBeClicked;

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnMouseDown () {
		theClickedRobotTag = this.gameObject.tag;
		timesBeClicked++;
//		Debug.Log (timesBeClicked);
	}
}
