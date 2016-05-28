using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Pontuação : MonoBehaviour {
	public Text MedalhasPlayer1;
	int pontosPlayer1;
	public GameObject BandeiraP1;
	public Text MedalhasPlayer2;
	public GameObject BandeiraP2;
	public int pontosPlayer2;
	double contagemPraDisputa;
	public Text TempoParaDisputa;
	double contagemPraDesaparecimento;
	public GameObject colisorbandeira;
	bool permissãopontuarP1;
	bool permissãopontuarP2;


	// Use this for initialization
	void Start () {
		pontosPlayer1 = 0;
		pontosPlayer2 = 0;
		contagemPraDisputa = 4;
		contagemPraDesaparecimento = 0;
		permissãopontuarP1 = false;
		permissãopontuarP2 = false;
	}

	void OnTriggerEnter(Collider colisorbandeira){

		if (colisorbandeira.gameObject.tag == "BandeiraP1" && pontosPlayer1 < 3) {
			permissãopontuarP1 = true;
			MedalhasPlayer1.text = "Victory Player1:" +pontosPlayer1;
			//Destroy (colisorbandeira.gameObject);
			//Application.LoadLevel ("Ambiente");
		}

		if (colisorbandeira.gameObject.tag == "BandeiraP2"  &&	 pontosPlayer2 < 3) {
			permissãopontuarP2 = true;
			MedalhasPlayer2.text = "Victory Player2:" +pontosPlayer2;
			//Destroy (colisorbandeira.gameObject);
			//Application.LoadLevel ("Ambiente");
		}
	}

	
	// Update is called once per frame
	void Update () {

		contagemPraDisputa -= Time.deltaTime;

		TempoParaDisputa.text = "Get Ready to Pull:" + contagemPraDisputa;
		MedalhasPlayer1.text = "Victory Player1:" + pontosPlayer1;
		MedalhasPlayer2.text = "Victory Player2:" + pontosPlayer2;

		if (contagemPraDisputa <= 1) {
				TempoParaDisputa.text = "GO";
			contagemPraDesaparecimento += Time.deltaTime;
			if (contagemPraDesaparecimento >= 1) {
				TempoParaDisputa.text = "";
			}
			if (permissãopontuarP1 == true) {
				pontosPlayer1++;
				permissãopontuarP1 = false;
			}
			if (permissãopontuarP2 == true) {
				pontosPlayer2++;
				permissãopontuarP2 = false;
			}
			MedalhasPlayer1.text = "Victory Player1:" +pontosPlayer1;
			MedalhasPlayer2.text = "Victory Player2:" +pontosPlayer2;
		}
	}
}


