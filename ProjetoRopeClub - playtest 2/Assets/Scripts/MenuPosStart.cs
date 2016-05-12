using UnityEngine;
using System.Collections;

public class MenuPosStart : MonoBehaviour {

	void OnGUI () {
		const int buttonWidth = 100;
		const int buttonHeight = 50;

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"Tutorial")) {

			Application.LoadLevel ("CenaTutorial01");


		}

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 3),
				buttonWidth, buttonHeight),
			"Jogo")) {

			Application.LoadLevel ("Ambiente");
		}

	}
}