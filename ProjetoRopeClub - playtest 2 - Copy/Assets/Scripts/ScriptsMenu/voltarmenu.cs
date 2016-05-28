using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class voltarmenu : MonoBehaviour {


	void OnGUI () {
		const int buttonWidth = 55;
		const int buttonHeight = 35;

		if (GUI.Button (
			new Rect (Screen.width / 2	- (buttonWidth / 30),
				(2 * Screen.height / 2.1f) - (buttonWidth / 1),
				buttonWidth, buttonHeight),
			"Voltar")) {

			SceneManager.LoadScene  ("Menu");


		}
	}
}
