using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	private AudioClip[] AudioListener;
	public Texture QualidadeGrafica,Resolucoes,ModoJanelaOuTelaCheia,volume,creditos,TexturaFundosmenu,TexturaGraficos;
	private bool EstaNoMenuPrincipal,EstaNosGraficos,EstaNosCreditos;
	public GUIStyle EstiloDosBotoesPrincipais,EstilodosBotoesGraficos; 
	private string ResoluçãoLargura = "1024",ResoluçãoAltura = "768";
	private float VOLUME;
	private int qualidadeGrafica;
	public Font Fonte;
	public int TamanhoDaLetra = 4;

	//Esse comando é feito para não destruir  o GameObject que receberá esse script,ele será utilizado para carregar a lista
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
	void Start ()
	{
		//Assim o menu começa com os botoes principais na tela
		EstaNoMenuPrincipal = true;
		//Habilitar o maouse
		Cursor.visible = true;
		//comando de pause
		Time.timeScale = 1;

		//PREFERENCIAS SALVAS
		if (PlayerPrefs.HasKey ("VOLUME")) { //Se existe uma chave chamada VOLUME
			VOLUME = PlayerPrefs.GetFloat ("VOLUME");//salva o valor da variavel VOLUME
		}
			else 
		{
			PlayerPrefs.SetFloat ("VOLUME",VOLUME);//Senão existir,cria esta chave
		}

		if (PlayerPrefs.HasKey ("QualidadeGrafica")) { //Se existe uma chave chamada QualidadeGrafica
			QualidadeGrafica = PlayerPrefs.GetFloat ("QualidadeGrafica");//salva o valor da variavel QualidadeGrafica
			QualitySettings.SetQualityLevel(QualidadeGrafica);//guarda a qualidade que está presente no project settings -> quality
		}
		else 
		{
			PlayerPrefs.SetFloat ("QualidadeGrafica",QualidadeGrafica);//Senão existir,cria esta chave
		}
	}

	void Update()
	{
		//preemcher arrays
		if(Application.loadedLevelName != "Menu")//pergunta se não está mais na cena menu
		{
			AudioListener = GameObject.FindObjectsOfType (typeof(AudioListener))as AudioListener[];//Load de todos os listeners carregados retornam para essa variavel
			AudioListener.volume = VOLUME;
			Destroy (gameObject);
		}
	}
}
