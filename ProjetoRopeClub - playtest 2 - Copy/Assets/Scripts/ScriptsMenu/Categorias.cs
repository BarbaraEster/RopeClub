using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Categorias : MonoBehaviour {

	void OnGUI () {
		const int buttonWidth = 150;
		const int buttonHeight = 80;

		if (GUI.Button (
			new Rect ((Screen.width / 4	- (buttonWidth / 2))+30,
				(1.6f * Screen.height / 4f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"MelhorDe1")) {

			SceneManager.LoadScene  ("MelhorDe1");


		}

		if (GUI.Button (
			new Rect ((Screen.width / 4	- (buttonWidth / 2))+30,
				(1.8f * Screen.height / 4f) - (buttonWidth / 3),
				buttonWidth, buttonHeight),
			"MelhorDe3")) {

			SceneManager.LoadScene  ("MelhorDe3");
		}

	}
}