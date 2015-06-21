using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreditsGUIScript : MonoBehaviour {
	
	// GUI Controls
	public Rect creditsRect;
	public Rect returnRect;
	
	public GUIContent titleContent;
	public GUIContent returnContent;

	// GUI Manager
	private GUIManagerScript guiManager;
	
	// Credits List
	Dictionary<string, string> creditsList = new Dictionary<string, string>();
	
	// Use this for initialization
	void Start () {
		
		creditsRect = new Rect(150, 100, 100, 50);
		returnRect = new Rect(100, Screen.height - 100, 100, 50);
		
		titleContent.text = "Credits";
		returnContent.text = "Return";

		creditsList.Add("Lyndon Wiese", "Project Manager");
		creditsList.Add("Matt Luesing", "Programmers");
		creditsList.Add("Sean", "Programmers");
		creditsList.Add("Emery", "Programmers");
		creditsList.Add("Randal Johnson", "Artist");
		
		guiManager = GetComponent<GUIManagerScript>();
	}
	
	void OnGUI () {
		
		GUI.Label(creditsRect, titleContent);
		
		if (GUI.Button(returnRect, returnContent)) {
			
			guiManager.enableScreen(MenuScreen.MainMenu);
			enabled = false;
		}

		string category = "";
		Rect creditRect = new Rect(Screen.width / 2 - 50, 120, 100, 50);
		int xOffset = 40;
		int yOffset = 40;

		foreach (KeyValuePair<string, string> value in creditsList) {

			if (!value.Value.Equals(category)) {

				category = value.Value;

				creditRect.x -= xOffset;
				GUI.Label(creditRect, value.Value);
				creditRect.x += xOffset;
				creditRect.y += yOffset;
			}

			GUI.Label(creditRect, value.Key);
			creditRect.y += yOffset;
		}
	}
}