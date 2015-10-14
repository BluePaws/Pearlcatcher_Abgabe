using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum GameState {
	startMenu,
	playing,
	quitMenu
}

public class GameController : MonoBehaviour {
	public static GameController script;
	
	// Public Inspector Fields
	public GameObject[] castles;

	//	UI
	public Canvas StartMenu;
	public Canvas QuitMenu;
	public Canvas GameHUD;

	public Slingshot SlingShotScript;
	

	public Vector3 castlePos;

	public bool startedGame;

	// Private internal fields

	private int level;
	private int levelMax;

	private GameObject castle;

	private GameState currentGameState;

	private string showing = "Slingshot";


	void Awake() {
		script = this;
		startedGame = false;

		// Initialize stuff (e.g. level, level Max)

		SetGameState (GameState.startMenu);

	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			SetGameState(GameState.quitMenu);
		}
	}
	
	public void SetGameState(GameState state)
	{
		switch(state)
		{
		case GameState.startMenu:	
			StartMenu.gameObject.SetActive(true);
			QuitMenu.gameObject.SetActive(false);
			GameHUD.gameObject.SetActive(false);
			SlingShotScript.Activate(false);
			break;
		
		case GameState.playing:		
			StartMenu.gameObject.SetActive(false);
			QuitMenu.gameObject.SetActive(false);
			GameHUD.gameObject.SetActive(true);
			SlingShotScript.Activate(true);
			startedGame = true;
			break;

		case GameState.quitMenu:		
			StartMenu.gameObject.SetActive(false);
			QuitMenu.gameObject.SetActive(true);
			GameHUD.gameObject.SetActive(false);
			SlingShotScript.Activate(false);
			break;
		}
		currentGameState  = state;
	}
	


}
