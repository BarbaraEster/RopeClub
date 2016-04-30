using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MedalhasPlayer1 : MonoBehaviour {

	int medalhasDoJogador1;
	public GUIText pontos01 = null;
	public GameObject Player1;
	// Use this for initialization
	void Start () {
		medalhasDoJogador1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		pontos01.text = "MedalhasPlayer1: " + Convert.ToString (medalhasDoJogador1);
		// colisão da bandeira com o colisor para pontuar
	}
}
