using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {

	public Slider MasterVolumeSlider;
	public Slider SFXVolumeSlider;
	public Slider MusicVolumeSlider;

	public MusicManager musicmanager;
	public Audio sfxmanager;



	void Start () {

		musicmanager = GameObject.FindObjectOfType<MusicManager>();
		MusicVolumeSlider.value = 0.4f;
		MusicVolumeSlider.value = PlayerPrefsManager.GetMusicVolume();
		sfxmanager = GameObject.FindObjectOfType<Audio>();
		SFXVolumeSlider.value = 0.4f;
		SFXVolumeSlider.value = PlayerPrefsManager.GetSFXVolume();

	}

	void Update () {

		musicmanager.SetVolume(MusicVolumeSlider.value);
		sfxmanager.SetVolume(SFXVolumeSlider.value);


		
	}

	public void SaveAndQuit() {

		PlayerPrefsManager.SetMusicVolume(MusicVolumeSlider.value);
		Debug.Log("Music value " + MusicVolumeSlider.value);
		PlayerPrefsManager.SetSFXVolume(SFXVolumeSlider.value);
		Debug.Log("SFX value " + SFXVolumeSlider.value);
	}

	public void SetDefaults() {

		PlayerPrefsManager.SetMusicVolume(0.15f);
		MusicVolumeSlider.value = 0.15f;
		PlayerPrefsManager.SetSFXVolume(0.2f);
		SFXVolumeSlider.value = 0.2f;
	
	}

}



