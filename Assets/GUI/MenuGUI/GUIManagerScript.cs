using UnityEngine;
using System.Collections;

public class GUIManagerScript : MonoBehaviour {

	public void enableScreen(MenuScreen menuScreen) {

		if (menuScreen.Equals(MenuScreen.MainMenu))
			GetComponent<MainMenuGUIScript>().enabled = true;
		if (menuScreen.Equals(MenuScreen.Credits))
			GetComponent<CreditsGUIScript>().enabled = true;
	}
}

public enum MenuScreen {
	
	MainMenu,
	Credits
}