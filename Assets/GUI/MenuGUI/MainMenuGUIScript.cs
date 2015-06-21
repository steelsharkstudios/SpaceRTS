using UnityEngine;
using System.Collections;

public class MainMenuGUIScript : MonoBehaviour {

	// GUI Controls
	public Rect titleRect;
	public Rect newGameRect;
	public Rect creditsRect;
	public Rect quitRect;

	public GUIContent titleContent;
	public GUIContent newGameContent;
	public GUIContent creditsContent;
	public GUIContent quitContent;
	
	// GUI Manager
	private GUIManagerScript guiManager;
	
	// Use this for initialization
	void Start () {

		titleRect = new Rect(Screen.width / 2 - 50, 100, 100, 50);
		newGameRect = new Rect(Screen.width / 2 - 100, 200, 200, 50);
		creditsRect = new Rect(Screen.width / 2 - 100, 300, 200, 50);
		quitRect = new Rect(Screen.width / 2 - 100, 400, 200, 50);

		titleContent.text = "Space RTS";
		newGameContent.text = "New Game";
		creditsContent.text = "Credits";
		quitContent.text = "Quit";

		guiManager = GetComponent<GUIManagerScript>();
	}

	void OnGUI () {

		GUI.Label(titleRect, titleContent);
		
		if (GUI.Button(newGameRect, newGameContent))
			Application.LoadLevel("SpaceRTS");
		
		if (GUI.Button(creditsRect, creditsContent)) {

			guiManager.enableScreen(MenuScreen.Credits);
			enabled = false;
		}
		
		if (GUI.Button(quitRect, quitContent))
			System.Diagnostics.Process.GetCurrentProcess().Kill();
	}
}