using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour {
	private Button bQuit;
	private Button bNewGame;

	void Start () {
		bNewGame = GameObject.Find ("ButtonNewGame").GetComponent<Button> ();
		bQuit = GameObject.Find ("ButtonQuit").GetComponent<Button> ();
		bQuit.onClick.AddListener (() => Game ("Quit"));
		bNewGame.onClick.AddListener (() => Game ("New"));
	}
	void Game(string Value){
		if (Value.Equals ("Quit")) {
			Application.Quit ();
		}
		if (Value.Equals ("New")) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
