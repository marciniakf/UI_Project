using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{

	const string MASTER_VOLUME_KEY = "master volume";
	const string SFX_VOLUME_KEY = "sfx volume";
	const string MUSIC_VOLUME_KEY = "music volume";

	private AudioSource audiosourceMusic;
	public AudioSource audiosourceSFX;


	public static void SetMasterVolume(float MasterVolume)
	{

		if (MasterVolume >= 0f && MasterVolume <= 3f)
		{

			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, MasterVolume);

		}
		else {

			Debug.LogError("MASTER volume out of range");

		}
	}

	public static float GetMasterVolume()
	{

		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);

	}

	public static void SetSFXVolume(float SFXVolume)
	{

		if (SFXVolume >= 0f && SFXVolume <= 3f){

			PlayerPrefs.SetFloat(SFX_VOLUME_KEY, SFXVolume);
		
		}
		else {

			Debug.LogError("SFX volume our of range");

		}
	}

	public static float GetSFXVolume() {

		return PlayerPrefs.GetFloat(SFX_VOLUME_KEY);
	}

	public static void SetMusicVolume(float MusicVolume) {

		if (MusicVolume >= 0f && MusicVolume <= 3f)
		{

			PlayerPrefs.SetFloat(MUSIC_VOLUME_KEY, MusicVolume);

		}
		else {
		
			Debug.LogError("MUSIC volume out of range");

		}
	
	}

	public static float GetMusicVolume() {

		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);

	}
}