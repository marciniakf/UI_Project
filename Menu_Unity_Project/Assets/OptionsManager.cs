using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {

	public Slider MasterVolumeSlider;
	public Slider SFXVolumeSlider;
	public Slider MusicVolumeSlider;

	private MusicManager musicmanager;
	private Audio sfxmanager;



	void Start () {

		musicmanager = GameObject.FindObjectOfType<MusicManager>();
		MusicVolumeSlider.value = PlayerPrefsManager.GetMusicVolume();
		sfxmanager = GameObject.FindObjectOfType<Audio>();
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

		PlayerPrefsManager.SetMusicVolume(0.1f);
		MusicVolumeSlider.value = 0.1f;
		PlayerPrefsManager.SetSFXVolume(0.2f);
		SFXVolumeSlider.value = 0.2f;
	
	}

}


//public class OptionsController : MonoBehaviour
//{

//	public Slider volumeSlider;
//	public Slider difficultySlider;
//	public LevelManager levelManager;
//	private MusicManager musicManager;


//	// Use this for initialization
//	void Start()
//	{

//		musicManager = GameObject.FindObjectOfType<MusicManager>(); // jest ze splasha
//		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
//		difficultySlider.value = PlayerPrefsManager.GetDifficulty();


//	}

//	// Update is called once per frame
//	void Update()
//	{

//		musicManager.SetVolume(volumeSlider.value);

//	}

//	public void SaveAndExit()
//	{

//		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
//		levelManager.LoadLevel("01 Start");
//		PlayerPrefsManager.SetDifficulty(difficultySlider.value);

//	}

//	public void SetDefaults()
//	{

//		PlayerPrefsManager.SetDifficulty(2);
//		difficultySlider.value = 2;
//		PlayerPrefsManager.SetMasterVolume(0.5f);
//		volumeSlider.value = 0.5f;

//	}
//}

