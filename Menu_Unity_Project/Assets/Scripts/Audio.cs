using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
	private AudioSource audiosource;

	public void Start()
	{

		audiosource = GetComponent<AudioSource>();

	}

	public void SetVolume(float volume)
	{

		audiosource.volume = volume;

	}
}

