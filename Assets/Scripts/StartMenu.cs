using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartMenu : MonoBehaviour {



	public Canvas quitMenu;
	public Button playButton;
	public Button exitButton;


	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas> ();
		playButton = playButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
	}


	public void ExitPress(){

		GameController.script.SetGameState (GameState.quitMenu);
		SoundController.script.PlayButtonTwo ();
	}

	public void NoPress (){

		if (GameController.script.startedGame) 
		{
			GameController.script.SetGameState(GameState.playing);
		} 
		else 
		{
			GameController.script.SetGameState (GameState.startMenu);
		}
		SoundController.script.PlayButtonTwo ();
	}

	public void StartGame ()
	{
		GameController.script.SetGameState (GameState.playing);
		SoundController.script.PlayButtonOne ();
		SoundController.script.LevelSoundtrack ();
	}

	public void ExitGame (){

		SoundController.script.PlayButtonOne ();
		Application.Quit();
	}

}
