using UnityEngine;
using System.Collections;

public class Comandos : MonoBehaviour {

	public float ForcaPlayer1;
	public float ForcaPlayer2;
	int clickPlayer1;
	int clickPlayer2; 
	public float staminaPlayer1;
	public float staminaPlayer2;
	// Use this for initialization
	void Start () {
		ForcaPlayer1 = 0.07f;
		ForcaPlayer2 = 0.07f;
		staminaPlayer1 = 1;
		staminaPlayer2 = 1;
		clickPlayer1 = 0;
		clickPlayer2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// comandos para encher a barra de stamina do jogador 1
		if (Input.GetKey (KeyCode.A) && staminaPlayer1 <= 100.0f) 
		{
			staminaPlayer1 += Time.deltaTime;
		}
		// comandos para encher a barra de stamina do jogador 2
		if (Input.GetKey (KeyCode.RightArrow) && staminaPlayer2 <= 100.0f) 
		{
			staminaPlayer2 += Time.deltaTime;
		}
		//comando para a aplicação de força do jogador 1  e aumento de força do jogador 1(aquecimento)
		if (Input.GetKeyDown (KeyCode.A) && staminaPlayer1 >= 1.0f) 
		{
			transform.Translate (-ForcaPlayer1 * staminaPlayer1, 0, 0);
			clickPlayer1++;
			if(clickPlayer1 == 15)
			{
				ForcaPlayer1 += 0.005f;
				clickPlayer1 = 0;
			}
		}
		//comando para a aplicação de força do jogador 2 e aumento de força do jogador 2(aquecimento)
		if (Input.GetKeyDown (KeyCode.RightArrow) && staminaPlayer2 >= 1.0f) 
		{
			transform.Translate (ForcaPlayer2 * staminaPlayer2, 0, 0);
			clickPlayer2++;
			if(clickPlayer2 == 15)
			{
				ForcaPlayer2 += 0.005f;
				clickPlayer2 = 0;
			}
		}
		// condição para diminuir a stamina do jogador 1
		if (staminaPlayer1 >= 2.0f){
			staminaPlayer1 -= 0.01f;

		}
		// condição para diminuir a stamina do jogador 2
		if (staminaPlayer2 >= 2.0f) {
			staminaPlayer2 -=  0.01f;
		}
	}
}
