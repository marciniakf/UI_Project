using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	public float FadeTime;

	private Image fadePanel;
	private Color currentColor = Color.black;


	void Start () {


		fadePanel = GetComponent<Image>();
		
	}
	

	void Update () {

		if (Time.timeSinceLevelLoad < FadeTime)
		{

			float AlphaChange = Time.deltaTime / FadeTime;
			currentColor.a -= AlphaChange;
			fadePanel.color = currentColor;

		}
		else {

			gameObject.SetActive(false);

		}
		
	}
}
