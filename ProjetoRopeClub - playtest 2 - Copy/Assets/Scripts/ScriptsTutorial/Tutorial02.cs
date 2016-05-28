using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Tutorial02 : MonoBehaviour{


	void OnGUI () {
		const int buttonWidth = 150;
		const int buttonHeight = 60;

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 2),
				(2 * Screen.height / 2.1f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"Next")) {

			SceneManager.LoadScene  ("CenaTutorial03");


		}
	}
}
