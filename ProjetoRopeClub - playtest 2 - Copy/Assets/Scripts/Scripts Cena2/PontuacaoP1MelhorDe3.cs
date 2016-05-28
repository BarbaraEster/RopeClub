using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontuacaoP1MelhorDe3 : MonoBehaviour {
	public Text MedalhasPlayer1;
	public int pontosPlayer1;
	public GameObject BandeiraP1;
	public GameObject Corda;
	public GameObject BandeiraP2;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject colisorbandeira;
	bool permissãopontuarP1;

	// Use this for initialization
	void Start () {
		pontosPlayer1 = 0;
		permissãopontuarP1 = false;
		PlayerPrefs.SetInt ("Victory Player1",pontosPlayer1);
	}
	void OnTriggerEnter(Collider colisorbandeira){
		int Medalhas = PlayerPrefs.GetInt ("Victory Player1");
		if (colisorbandeira.gameObject.tag == "BandeiraP1" && Medalhas < 3) {
			permissãopontuarP1 = true;
			MedalhasPlayer1.text = "Victory Player1:" +Medalhas;
			//SceneManager.LoadScene ("MelhorDe3");
		}
	}
	
	// Update is called once per frame
	void Update () {
		int Medalhas = PlayerPrefs.GetInt ("Victory Player1");
		MedalhasPlayer1.text = "Victory Player1:" + Medalhas;
			if (permissãopontuarP1 == true) {
				Medalhas++;
				permissãopontuarP1 = false;
			}
		MedalhasPlayer1.text = "Victory Player1:" +Medalhas;

		if (Medalhas == 2) 
		{
			SceneManager.LoadScene ("VitoriaPlayer1M3");
		}
		}
}

