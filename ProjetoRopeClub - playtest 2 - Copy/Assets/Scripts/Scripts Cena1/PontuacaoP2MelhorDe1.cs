using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontuacaoP2MelhorDe1 : MonoBehaviour {
	public Text MedalhasPlayer2;
	public GameObject BandeiraP1;
	public GameObject Corda;
	public GameObject BandeiraP2;
	public GameObject Player1;
	public GameObject Player2;
	public int pontosPlayer2;
	public GameObject colisorbandeira;
	bool permissãopontuarP2;




	// Use this for initialization
	void Start () {
		pontosPlayer2 = 0;
		permissãopontuarP2 = false;

	
	}
	void OnTriggerEnter(Collider colisorbandeira){
		if (colisorbandeira.gameObject.tag == "BandeiraP2"  &&	 pontosPlayer2 <= 1) {
			permissãopontuarP2 = true;
		}
	}

	
	// Update is called once per frame
	void Update () {
			if (permissãopontuarP2 == true) {
				pontosPlayer2++;
				permissãopontuarP2 = false;
			SceneManager.LoadScene ("VitoriaPlayer2M1");
			}
		}
}
