using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour {

    private AudioSource musicPlayer;

    private float musicVolume = 1f;

	// Use this for initialization
	void Start () {

        musicPlayer = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        // setting the volume option of the audio source should be equal to music volume
        musicPlayer.volume = musicVolume;
	}

    // Method to be used by the slider game object
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
