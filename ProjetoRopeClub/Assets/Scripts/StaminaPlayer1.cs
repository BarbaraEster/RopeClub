using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StaminaPlayer1 : MonoBehaviour {
	
	double staminaPlayer1;
	public GUIText staminaP1 = null;
	// Use this for initialization
	void Start () {
		staminaPlayer1 = 1.0;
	}
	
	// Update is called once per frame
	void Update () {
		// comandos para encher a barra de stamina do jogador 1
		if (Input.GetKey (KeyCode.A) && staminaPlayer1 <= 100.0f) 
		{
			staminaPlayer1 += Time.deltaTime;
		}
		// condição para diminuir a stamina do jogador 1
		if (staminaPlayer1 >= 2.0f) {
			staminaPlayer1 -= 0.01f;

		}
		staminaP1.text = "StaminaJogador1:" + Convert.ToString (staminaPlayer1);
	}
}
