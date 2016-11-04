using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeoutText : MonoBehaviour {

	Text CityNameText;
	float colorAlpha = 1f;

	void Start () {
		CityNameText = GameObject.Find ("CityName").GetComponent<Text> ();

	}

	void Update () {
		StartCoroutine (turnOffText ());
	}

	IEnumerator turnOffText () {
		yield return new WaitForSeconds (3);
		colorAlpha -= .075f;
		CityNameText.color = new Color(CityNameText.color.r, CityNameText.color.g, CityNameText.color.b, colorAlpha);
	}
}
