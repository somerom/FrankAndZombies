using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
/// <summary>
/// Game controller class handles the movement
/// of the player, animations of the player and
/// the menu button
/// </summary>
public class GameController : MonoBehaviour {
	private ButtonController bLeft;
	private ButtonController bRight;
	private ButtonController bUp;
	private ButtonController bDown;
	private GameObject player;
	public static Vector2 playerDir;
	public float speed = 0.01f;
    public string position;
    private int intro = 0;
	Animator anim;
	private Button buttonMenu;


	void Start () {

        player = GameObject.Find("Player");
        bLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		bRight = GameObject.Find ("ButtonRight").GetComponent<ButtonController> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		bDown = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
        position = "0";
		anim = GameObject.Find ("Player").GetComponent<Animator> ();
		buttonMenu = GameObject.Find ("ButtonMenu").GetComponent<Button> ();
		buttonMenu.onClick.AddListener (() => PauseMenu ("Open"));
		playerDir = Vector2.down;
	}

	void Update () {
		anim.speed = 0f;
		if (bLeft.GetButtonPressed () == true) {
			anim.speed = 1f;
			anim.SetInteger ("State", 3);
			player.transform.Translate (-1.0f * speed, 0, 0);
			SetPlayerDir (Vector2.left);
		}
		if (bRight.GetButtonPressed ()== true) {
			anim.speed = 1f;
			anim.SetInteger ("State", 1);
			player.transform.Translate (1.0f * speed, 0, 0);
			SetPlayerDir (Vector2.right);
		}
		if (bUp.GetButtonPressed ()==true) {
			anim.speed = 1f;
			anim.SetInteger ("State", 2);
			player.transform.Translate (0, 1.0f * speed, 0);
			SetPlayerDir (Vector2.up);
		}
		if (bDown.GetButtonPressed ()==true) {
			anim.speed = 1f;
			anim.SetInteger ("State", 4);
			player.transform.Translate (0,-1.0f * speed, 0);
			SetPlayerDir (Vector2.down);

		}
	}
		private void PauseMenu (string Value){
		if (Value.Equals ("Open")) {
			SceneManager.LoadScene ("Menu");
		}
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            GameItem gi = new GameItem();
            gi.SetName(collision.gameObject.name);
        }
    }

	public Vector2 GetPlayerDir()
	{
		return playerDir;
	}

	void SetPlayerDir(Vector2 Dir)
	{
		playerDir = Dir;
	}

	public void SetPosition (){
		player.transform.position = new Vector3 (0, 0, 0);
	}


    /*
	[Serializable]
	class PlayerData{
		

	}
  		private void Save (){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.presistentDataPath + "/savegame.dat", FileMode.Open);

		PlayerData data = new PlayerData ();


		bf.Serialize (file, data);
		file.Close ();
	}
	private void Load (){

	}
	*/
}


