using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class VitoriaM1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void menu()
	{
		SceneManager.LoadScene  ("Menu");
	}
	public void retry()
	{
		SceneManager.LoadScene  ("MelhorDe1");
	}
}
