using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	float Forca;
	Vector3 posicionamento;
	// Use this for initialization
	void Start () {
		Forca = 0.1f;
		posicionamento = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			transform.Translate (-Forca, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			transform.Translate (Forca, 0, 0);
		}
	
	}
}
