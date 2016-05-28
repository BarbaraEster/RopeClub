using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StaminaPlayer1 : MonoBehaviour {
	
	double staminaPlayer1;
	public Text staminaP1;
	double contagemPraDisputa;
	// Use this for initialization
	void Start () {
		staminaPlayer1 = 1.0;
		contagemPraDisputa = 4;
	}
	
	// Update is called once per frame
	void Update () {
		contagemPraDisputa -= Time.deltaTime;
		staminaP1.text = "PullForcePlayer1:" + Convert.ToString (staminaPlayer1);
		if (contagemPraDisputa <= 0) {
			// comandos para encher a barra de stamina do jogador 1
			if (Input.GetKey (KeyCode.A) && staminaPlayer1 <= 100.0f) {
				staminaPlayer1 += Time.deltaTime;
			}
			// condição para diminuir a stamina do jogador 1
			if (staminaPlayer1 >= 2.0f) {
				staminaPlayer1 -= 0.01f;

			}
			staminaP1.text = "PullForcePlayer1:" + Convert.ToString (staminaPlayer1);
		}
	}
}
