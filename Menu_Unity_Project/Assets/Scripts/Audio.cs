using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
	private AudioSource audiosource;
	public OptionsManager optionsManager;

	public void Start()
	{

		audiosource = GetComponent<AudioSource>();
		optionsManager.SetDefaults();
	}

	public void SetVolume(float volume)
	{
		
		audiosource.volume = volume;

	}
}


