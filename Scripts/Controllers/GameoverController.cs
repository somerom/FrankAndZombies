using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverController : MonoBehaviour {
	
	private Button bNewGame;
	private Button bQuit;
	GameController gm = new GameController ();
	private GameObject player;
	Inventory inv = new Inventory ();
	private Text hitpoints;
	private GameObject player1;


	void Start () {
		bNewGame = GameObject.Find ("ButtonNewGame").GetComponent<Button> ();
		bQuit = GameObject.Find ("ButtonQuit").GetComponent<Button> ();
		bNewGame.onClick.AddListener(() => Game ("New"));
		bQuit.onClick.AddListener(() => Game ("Quit"));
		player = GameObject.Find ("Player");
		hitpoints = GameObject.Find ("HitPointText").GetComponent<Text> ();


	}
			void Game (string Value) {
				if(Value.Equals("Continue")){
					
				}
				if(Value.Equals("New")){
			player.transform.position = new Vector3 (0, 0, 0);
			inv.Reset ();
			SceneManager.LoadScene ("Main");
			hitpoints.text= ("HP: 3");
				}
				if(Value.Equals("Quit")){
			Application.Quit ();
				}
			}
}
