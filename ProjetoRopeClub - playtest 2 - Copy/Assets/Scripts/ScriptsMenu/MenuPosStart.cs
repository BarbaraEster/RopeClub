using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuPosStart : MonoBehaviour {

	void OnGUI () {
		const int buttonWidth = 150;
		const int buttonHeight = 80;

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"Tutorial")) {

			SceneManager.LoadScene  ("CenaTutorial01");


		}

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 3),
				buttonWidth, buttonHeight),
			"Jogo")) {

			SceneManager.LoadScene  ("Categorias");
		}

	}
}