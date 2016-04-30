using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StaminaPlayer2 : MonoBehaviour {
	
	double staminaPlayer2;
	public GUIText staminaP2 = null;
	// Use this for initialization
	void Start () {
		staminaPlayer2 = 1.0;
	}
	
	// Update is called once per frame
	void Update () {
		// comandos para encher a barra de stamina do jogador 2
		if (Input.GetKey (KeyCode.RightArrow) && staminaPlayer2 <= 100.0f) 
		{
			staminaPlayer2 += Time.deltaTime;
		}
		// condição para diminuir a stamina do jogador 2
		if (staminaPlayer2 >= 2.0f) {
			staminaPlayer2 -=  0.01f;
		}
		staminaP2.text = "StaminaJogador2:" + Convert.ToString (staminaPlayer2);
	
	}
}
