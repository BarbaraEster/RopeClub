using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


	void OnGUI () {
		const int buttonWidth = 100;
		const int buttonHeight = 35;

		if (GUI.Button (
			    new Rect (Screen.width / 2	- (buttonWidth / 2),
				    (2 * Screen.height / 2.1f) - (buttonWidth / 1),
				    buttonWidth, buttonHeight),
			    "Start")) {

			Application.LoadLevel ("MenuPosStart");


		}
			
		if (GUI.Button (
			    new Rect (Screen.width / 2	- (buttonWidth / 2),
				    (2 * Screen.height / 2.1f) - (buttonWidth / 3),
				    buttonWidth, buttonHeight),
			    "Credito")) {

			Application.LoadLevel ("credito");
		}

	}
}

