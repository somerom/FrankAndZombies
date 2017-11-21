using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameController : MonoBehaviour {
	private ButtonController bLeft;
	private ButtonController bRight;
	private ButtonController bUp;
	private ButtonController bDown;
	private GameObject player;
	public float speed = 0.01f;
    public string position;
	Animator anim;
	private Button buttonMenu;
	private Button bTalk;


	void Start () {
		player = GameObject.Find ("Player");
		bLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		bRight = GameObject.Find ("ButtonRight").GetComponent<ButtonController> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		bDown = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
        position = "0";
		anim = GameObject.Find ("Player").GetComponent<Animator> ();
		buttonMenu = GameObject.Find ("ButtonMenu").GetComponent<Button> ();
		buttonMenu.onClick.AddListener (() => PauseMenu ("Open"));
		bTalk = GameObject.Find ("ButtonTalk").GetComponent<Button> ();
		bTalk.onClick.AddListener(TalkTo);
	}

	void Update () {
		if (bLeft.GetButtonPressed () == true) {
			anim.SetInteger ("State", 3);
			player.transform.Translate (-0.157f * speed, 0, 0);

		}
		if (bRight.GetButtonPressed ()== true) {
			anim.SetInteger ("State", 1);
			player.transform.Translate (0.157f * speed, 0, 0);

		}
		if (bUp.GetButtonPressed ()==true) {
			anim.SetInteger ("State", 2);
			player.transform.Translate (0, 0.157f * speed, 0);

		}
		if (bDown.GetButtonPressed ()==true) {
			anim.SetInteger ("State", 4);
			player.transform.Translate (0,-0.157f * speed, 0);
		
		}
	}
		private void PauseMenu (string Value){
		if (Value.Equals ("Open")) {
			SceneManager.LoadScene (0);
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
    public void SetPath(string path)
    {
        Debug.Log(path);
    }
    public string GetPosition()
    {
        return position;
    }
    public void SetPosition(string p)
    {
        this.position = p;
    }

	void TalkTo()
	{
		Debug.Log ("talk pressed");
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


