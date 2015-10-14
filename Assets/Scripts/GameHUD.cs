using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour {


	public Text shotsTaken;
	
	public static GameHUD script;

	private int shotCounter = 0;

	void Awake()
	{
		script = this;
	}

	public void takeShot ()
	{
		shotCounter++;

		shotsTaken.text = "Shots Taken: " + shotCounter.ToString();
	}
}
