using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PontuacaoJogo : MonoBehaviour {

	float tempo = 3.0f;
	public GUIText time = null;
	//public Text 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		tempo -= Time.deltaTime;
		time.text ="Time:" + Convert.ToString (tempo);
		if (tempo <= 0)
			Debug.Log ("Acabou o tempo");
	}
}
