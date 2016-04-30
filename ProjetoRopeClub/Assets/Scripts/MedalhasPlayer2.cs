using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MedalhasPlayer2 : MonoBehaviour {
	
	int medalhasDoJogador2;
	public GUIText pontos02 = null;
	public GameObject Player1;
	// Use this for initialization
	void Start () {
		medalhasDoJogador2 = 0;
	}
	
	// Update is called once per frame
	void Update () {

		pontos02.text = "MedalhasPlayer2: " + Convert.ToString (medalhasDoJogador2);
		// colisão da bandeira com o colisor para pontuar

	}
}
