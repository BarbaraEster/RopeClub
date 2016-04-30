using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MedalhasPlayer1 : MonoBehaviour {

	int medalhasDoJogador1;
	public GUIText pontos01 = null;
	public GameObject BandeiraP1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		medalhasDoJogador1 = 0;
		pontos01.text = "MedalhasPlayer1: " + Convert.ToString (medalhasDoJogador1);

		if (BandeiraP1.transform.position.x <= 0) 
		{
			medalhasDoJogador1++;
		}

	
	}
}
