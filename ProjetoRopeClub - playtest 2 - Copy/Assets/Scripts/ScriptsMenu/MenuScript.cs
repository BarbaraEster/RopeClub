using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {


	void OnGUI () {
		const int buttonWidth = 150;
		const int buttonHeight = 40;

		if (GUI.Button (
			new Rect ((Screen.width / 4	- (buttonWidth / 2))+30,
				    (1.6f * Screen.height / 4f) - (buttonWidth / 1),
				    buttonWidth, buttonHeight),
			    "Start")) {

			SceneManager.LoadScene  ("MenuPosStart");


		}
			
		if (GUI.Button (
			new Rect ((Screen.width / 4	- (buttonWidth / 2))+30,
				(1.8f * Screen.height / 4f) - (buttonWidth / 3),
				    buttonWidth, buttonHeight),
			    "Credito")) {

			SceneManager.LoadScene  ("credits");
		}

	}
	void OnMouseOver()
	{
		const int buttonWidth = 150;

		GetComponent<Transform> ().localScale = new Vector3 ((Screen.width / 4	- (buttonWidth / 2))+30,(1.6f * Screen.height / 4f) - (buttonWidth / 1),-10);
		GetComponent<TextMesh> ().color = new Color (0,0,0,1);
	}
	void OnMouseExit()
	{
		const int buttonWidth = 150;

		GetComponent<Transform> ().localScale = new Vector3 ((Screen.width / 4	- (buttonWidth / 2))+30,(1.6f * Screen.height / 4f) - (buttonWidth / 1),-10);
		GetComponent<TextMesh> ().color = new Color (255,255,255,1);
	}


	void OnMouseDown()
	{
		
		SceneManager.LoadScene  ("MenuPosStart");
	}
}

