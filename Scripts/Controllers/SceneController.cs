using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// Scene controller class handles the main menu scene
/// </summary>
public class SceneController : MonoBehaviour {
	/// <summary>
	/// Creating all the buttons and objects on the menu screen
	/// </summary>
	private Button bNewGame;
	private Button bQuit;
	private Button bHelp;
	private GameObject helpScreen;
	private Button bExit;
	private GameObject player;
	private GameObject canvase;
	private GameObject camera1;
	/// <summary>
	/// Telling the game where each button is found in and what happens
	/// when you press it
	/// </summary>
	void Start () {
		bNewGame = GameObject.Find ("ButtonNewGame").GetComponent<Button> ();
		bQuit = GameObject.Find ("ButtonQuit").GetComponent<Button> ();
		bHelp = GameObject.Find ("ButtonHelp").GetComponent<Button> ();
		bNewGame.onClick.AddListener (() => Game ("New"));
		bQuit.onClick.AddListener (() => Game ("Quit"));
		bHelp.onClick.AddListener (() => Game ("Help"));
		helpScreen = GameObject.Find ("HelpScreen");
		bExit = GameObject.Find ("ButtonExit").GetComponent<Button> ();
		bExit.onClick.AddListener (() => Game ("Exit"));
		helpScreen.SetActive (false);
		player = GameObject.Find ("Player");
		canvase = GameObject.Find ("Canvas2");
		camera1 = GameObject.Find ("Main Camera");

	}
	/// <summary>
	/// Game is run when ever a button is pressed 
	/// and depending on the button it gives a different
	/// value
	/// </summary>
	/// <param name="value">Value.</param>
	void Game (string value) {
		if (value.Equals ("New")) {
			if(player != null){
				Destroy (player);
				Destroy (canvase);
				DestroyImmediate (camera1);
			} 
			SceneManager.LoadScene ("Intro");
		}
		if (value.Equals ("Quit")){
			Application.Quit ();
		}
		if (value.Equals ("Help")) {
			helpScreen.SetActive (true);
			bExit = GameObject.Find ("ButtonExit").GetComponent<Button> ();
			bExit.onClick.AddListener (() => Game ("Exit"));
		}
		if (value.Equals ("Exit")) {
			helpScreen.SetActive (false);
		}
	}

	void Update () {
		
	}
}
