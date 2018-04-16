using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeMusicVolume : MonoBehaviour {

	// Use this for initialization

	public Slider Volume;
	public AudioSource MyMusic;


	// Update is called once per frame

	void update () {
	
		MyMusic.volume = Volume.value;
	
	}


}
