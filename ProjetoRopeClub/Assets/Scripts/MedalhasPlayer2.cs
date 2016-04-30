using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MedalhasPlayer2 : MonoBehaviour {
	
	int medalhasDoJogador2;
	public GUIText pontos02 = null;
	public GameObject BandeiraP2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		medalhasDoJogador2 = 0;
		pontos02.text = "MedalhasPlayer2: " + Convert.ToString (medalhasDoJogador2);

		if (BandeiraP2.transform.position.x <= 0) 
		{
			medalhasDoJogador2++;
		}
	}
}
