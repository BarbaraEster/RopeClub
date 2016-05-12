using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Pontuação : MonoBehaviour {
	public Text MedalhasPlayer1;
	float pontosPlayer1;
	public GameObject BandeiraP1;
	public Text MedalhasPlayer2;
	public GameObject BandeiraP2;
	float pontosPlayer2;
	double contagemPraDisputa;
	public Text TempoParaDisputa;
	double contagemPraDesaparecimento;
	// Use this for initialization
	void Start () {
		pontosPlayer1 = 0;
		pontosPlayer2 = 0;
		contagemPraDisputa = 4;
		contagemPraDesaparecimento = 0;

	}
	
	// Update is called once per frame
	void Update () {

		contagemPraDisputa -= Time.deltaTime;

		TempoParaDisputa.text = "Preparem-se:" + contagemPraDisputa;
		MedalhasPlayer1.text = "Vitórias Jogador1:" + pontosPlayer1;
		MedalhasPlayer2.text = "Vitórias Jogador2:" + pontosPlayer2;

		if (contagemPraDisputa <= 1) {
				TempoParaDisputa.text = "GO";
			contagemPraDesaparecimento += Time.deltaTime;
			if (contagemPraDesaparecimento >= 1) {
				TempoParaDisputa.text = "";
			}
			while (BandeiraP1.transform.position.x <= (Screen.width / 100) && pontosPlayer1 < 3) {
				pontosPlayer1++;

			}
			while (BandeiraP2.transform.position.x >= (Screen.width / 100) && pontosPlayer2 < 3) {
				pontosPlayer2++;

			}

			MedalhasPlayer1.text = "Vitórias Jogador1:" + pontosPlayer1;
			MedalhasPlayer2.text = "Vitórias Jogador2:" + pontosPlayer2;
		}
	}
}
