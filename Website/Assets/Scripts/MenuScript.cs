﻿using UnityEngine;


public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
		);
	
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Start!"))
		{
			Application.LoadLevel("Stage1");
		}
	}
}
