using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
	private Button bQuit;
	private Button bNewGame;
	private Button bHelp;
	private Button bContinue;
	public GameObject canvasObject;
	private Button bExit;

	void Start () {
		bNewGame = GameObject.Find ("ButtonNewGame").GetComponent<Button> ();
		bContinue = GameObject.Find ("ButtonContinue").GetComponent<Button> ();
		bQuit = GameObject.Find ("ButtonQuit").GetComponent<Button> ();
		bHelp = GameObject.Find ("ButtonHelp").GetComponent<Button> ();
		bQuit.onClick.AddListener (() => Game ("Quit"));
		bNewGame.onClick.AddListener (() => Game ("New"));
		bContinue.onClick.AddListener (() => Game ("Cont"));
		bHelp.onClick.AddListener (() => Game ("Help"));
	}
	void Game(string Value){
	if (Value.Equals ("Quit")) {
		Application.Quit ();
	}
			
	if (Value.Equals ("New")) {
		SceneManager.LoadScene (1);
		}
	if(Value.Equals ("Cont")){
	}
	if (Value.Equals ("Help")) {
			canvasObject.SetActive (true);
			bExit = GameObject.Find ("ButtonExit").GetComponent<Button> ();
			bExit.onClick.AddListener (() => Game ("Close"));
		}
		if (Value.Equals ("Close")) {
			canvasObject.SetActive (false);
		}
}
}
