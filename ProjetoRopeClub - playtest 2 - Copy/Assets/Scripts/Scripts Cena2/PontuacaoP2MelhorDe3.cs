using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontuacaoP2MelhorDe3 : MonoBehaviour {
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
		PlayerPrefs.SetInt ("Victory Player2",pontosPlayer2);
	
	}
	void OnTriggerEnter(Collider colisorbandeira){
		int Medalhas = PlayerPrefs.GetInt ("Victory Player2");
		if (colisorbandeira.gameObject.tag == "BandeiraP2"  &&	 Medalhas < 3) {
			permissãopontuarP2 = true;
			MedalhasPlayer2.text = "Victory Player2:" +Medalhas;
			//SceneManager.LoadScene ("MelhorDe3");
		}
	}

	
	// Update is called once per frame
	void Update () {
		int Medalhas = PlayerPrefs.GetInt ("Victory Player2");
		MedalhasPlayer2.text = "Victory Player2:" + pontosPlayer2;
			if (permissãopontuarP2 == true) {
				Medalhas++;
				permissãopontuarP2 = false;
			}
			MedalhasPlayer2.text = "Victory Player2:" +Medalhas;

		if (Medalhas == 2) 
		{
			SceneManager.LoadScene ("VitoriaPlayer2M3");
		}
		}
}
