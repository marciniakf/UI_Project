using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public AudioClip[] LevelMusicArray;
	private AudioSource audiosource;

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {

		audiosource = GetComponent<AudioSource>();


	}

	void OnLevelWasLoaded(int level) {

		AudioClip thislevelaudio = LevelMusicArray[level];

		if (thislevelaudio) {

			audiosource.volume = 0.1f;
			Debug.Log("Volume changed");
			audiosource.clip = thislevelaudio;
			audiosource.loop = true;
			audiosource.Play();
		}
	}

	public void SetVolume(float volume) {

		audiosource.volume = volume;

	}
}
