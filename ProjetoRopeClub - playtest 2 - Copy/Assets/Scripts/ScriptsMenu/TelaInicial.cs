using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class TelaInicial : MonoBehaviour {


	string start;
	public Font Fonte;

	void Start()
	{
		start = "Press  Enter";
	}

	void OnGUI()
	{
		GUI.skin.font = Fonte;

		GUI.Label (new Rect((Screen.width/2)-150,Screen.height/2 + Screen.height/4,Screen.width,Screen.height),start);
		if (Input.GetKeyDown (KeyCode.Return))
		{
			SceneManager.LoadScene  ("Menu");
		}
	}
		
}
