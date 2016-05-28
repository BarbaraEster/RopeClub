using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Bandeira1Cena1 : MonoBehaviour {
	float ForcaPlayer2;
	int clickPlayer2;
	float staminaPlayer2;
	float ForcaPlayer1;
	int clickPlayer1;
	float staminaPlayer1;
	double contagemPraDisputa;
	// Use this for initialization
	void Start () {
		ForcaPlayer1 = 0.07f;
		clickPlayer1 = 0;
		staminaPlayer1 = 1.0f;
		ForcaPlayer2 = 0.07f;
		staminaPlayer2 = 1.0f;
		clickPlayer2 = 0;
		contagemPraDisputa = 4;

	}

	// Update is called once per frame
	void Update () {
		
		contagemPraDisputa -= Time.deltaTime;

		if (contagemPraDisputa <= 0) {
			// comandos para encher a barra de stamina do jogador 1
			if (Input.GetKey (KeyCode.A) && staminaPlayer1 <= 100.0f) {
				staminaPlayer1 += Time.deltaTime;
			}

			//comando para a aplicação de força do jogador 1  e aumento de força do jogador 1(aquecimento)
			if (Input.GetKeyDown (KeyCode.A) && staminaPlayer1 >= 1.0f) {
				transform.Translate (-ForcaPlayer1 * staminaPlayer1, 0, 0);
				clickPlayer1++;
				if (clickPlayer1 == 10) {
					ForcaPlayer1 += 0.005f;
					clickPlayer1 = 0;
				}

			}
			// condição para diminuir a stamina do jogador 1
			if ((staminaPlayer1 >= 2.0f) && Input.GetKey (KeyCode.A) == false) {
				staminaPlayer1 -= 0.01f;

			}

			// comandos para encher a barra de stamina do jogador 2
			if (Input.GetKey (KeyCode.RightArrow) && staminaPlayer2 <= 100.0f) {
				staminaPlayer2 += Time.deltaTime;
			}

			//comando para a aplicação de força do jogador 1  e aumento de força do jogador 1(aquecimento)
			if (Input.GetKeyDown (KeyCode.RightArrow) && staminaPlayer2 >= 1.0f) {
				transform.Translate (ForcaPlayer2 * staminaPlayer2, 0, 0);
				clickPlayer2++;
				if (clickPlayer2 == 10) {
					ForcaPlayer2 += 0.005f;
					clickPlayer2 = 0;
				}

			}
			// condição para diminuir a stamina do jogador 2
			if ((staminaPlayer2 >= 2.0f) && Input.GetKey (KeyCode.RightArrow) == false) {
				staminaPlayer2 -= 0.01f;

			}
		}
	}
}
