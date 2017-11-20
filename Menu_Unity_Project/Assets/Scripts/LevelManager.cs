using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public float LoadLevelAfter;

	// Use this for initialization
	void Start () {

		if (LoadLevelAfter == 0)
		{
			Debug.Log("Auto load disabled");
		}
		else {

			Invoke("LoadNextLevel", LoadLevelAfter);
		}



	}

	public void LoadLevel(string name) {

		Debug.Log("New level loaded " + name);
		Application.LoadLevel(name);

	}

	public void LoadNextLevel() {

		Application.LoadLevel(Application.loadedLevel + 1);
		Debug.Log("Loading next level");
	}
}

