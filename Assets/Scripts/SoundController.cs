using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	public AudioClip ButtonBlubb1;
	public AudioClip ButtonBlubb2;
	public AudioClip Intro;
	public AudioClip[] LevelTrack;

	public AudioSource MusicSource;

	public static SoundController script;


	private AudioSource Player;

	void Awake ()
	{
		script = this;
		Player = GetComponent<AudioSource> ();
		PlayIntro ();
	}




	public void PlayButtonOne ()
	{
		Player.PlayOneShot (ButtonBlubb1);
	}

	public void PlayButtonTwo ()
	{
		Player.PlayOneShot (ButtonBlubb2);
	}

	public void PlayIntro ()
	{
		MusicSource.PlayOneShot (Intro);
	}

	public void LevelSoundtrack ()
	{
		int rand = Random.Range (0, LevelTrack.Length);
		MusicSource.clip = LevelTrack [rand];
		MusicSource.Play ();
	}
}
