using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StaminaPlayer2 : MonoBehaviour {
	
	double staminaPlayer2;
	public Text staminaP2;
	double contagemPraDisputa;
	// Use this for initialization
	void Start () {
		staminaPlayer2 = 1.0;
		contagemPraDisputa = 4;
	}
	
	// Update is called once per frame
	void Update () {
		contagemPraDisputa -= Time.deltaTime;
		staminaP2.text = "PullForcePlayer2:" + Convert.ToString (staminaPlayer2);
		if (contagemPraDisputa <= 0) {
			// comandos para encher a barra de stamina do jogador 2
			if (Input.GetKey (KeyCode.RightArrow) && staminaPlayer2 <= 100.0f) {
				staminaPlayer2 += Time.deltaTime;
			}
			// condição para diminuir a stamina do jogador 2
			if (staminaPlayer2 >= 2.0f) {
				staminaPlayer2 -= 0.01f;
			}
			staminaP2.text = "PullForcePlayer2:" + Convert.ToString (staminaPlayer2);
	
		}
	}
}
