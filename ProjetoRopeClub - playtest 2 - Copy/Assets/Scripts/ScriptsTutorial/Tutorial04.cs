using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Tutorial04 : MonoBehaviour {

	void OnGUI () {
		const int buttonWidth = 150;
		const int buttonHeight = 60;

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"Jogo")) {

			SceneManager.LoadScene  ("Categorias");


		}

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.5f) - (buttonWidth / 3),
				buttonWidth, buttonHeight),
			"Tutorial")) {

			SceneManager.LoadScene  ("CenaTutorial01");
		}

	}
}