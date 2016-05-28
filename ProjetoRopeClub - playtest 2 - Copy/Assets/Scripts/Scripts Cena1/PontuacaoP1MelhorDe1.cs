using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontuacaoP1MelhorDe1 : MonoBehaviour {
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

	}
	void OnTriggerEnter(Collider colisorbandeira){

		if (colisorbandeira.gameObject.tag == "BandeiraP1" && pontosPlayer1 < 1) {
			permissãopontuarP1 = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
			if (permissãopontuarP1 == true) {
				pontosPlayer1++;
				permissãopontuarP1 = false;
			SceneManager.LoadScene ("VitoriaPlayer1M1");
			}
		}
}

