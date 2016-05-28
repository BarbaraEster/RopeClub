using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontuacaoP1 : MonoBehaviour {
	public Text MedalhasPlayer1;
	public static int pontosPlayer1;
	public GameObject BandeiraP1;
	public GameObject Corda;
	public GameObject BandeiraP2;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject colisorbandeira;
	bool permissãopontuarP1;
	//Vector3 posBandeiraP1;
	//Vector3 posBandeiraP2;
	//Vector3 posCorda;
	//Vector3 posPlayer1;
	//Vector3 posPlayer2;
	// Use this for initialization
	void Start () {

		pontosPlayer1 = 0;
		permissãopontuarP1 = false;
		PlayerPrefs.SetInt ("Victory Player1",pontosPlayer1);


	}
	void OnTriggerEnter(Collider colisorbandeira){
		int Medalhas = PlayerPrefs.GetInt ("Victory Player1");
		if (colisorbandeira.gameObject.tag == "BandeiraP1" && Medalhas < 2) {
			permissãopontuarP1 = true;
			MedalhasPlayer1.text = "Victory Player1:" + Medalhas;
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
			SceneManager.LoadScene ("VitoriaPlayer1");
		}
		}

}

