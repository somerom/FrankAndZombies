using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HitPoints: MonoBehaviour {
	
	private int hitPoints = 3;

	Text HPText;

	void Start()
	{
		HPText = GameObject.Find("HitPointText").GetComponent<Text>();
	}

	void Update () {
		if (hitPoints == 0) {
			GameOver ();
		}
	}

	public void GainHP()
	{
		hitPoints++;
	}

	public void TakeDamage()
	{
		hitPoints--;
		string temp = "HP: " + hitPoints;
		Debug.Log (temp);
		HPText.text = temp;
	}

	void GameOver()
	{
		SceneManager.LoadScene (2);
	}

	void OnCollisionEnter2D(Collision2D Collision)
	{
		if (Collision.gameObject.tag == "Enemy") {
			Debug.Log ("took damage");
			TakeDamage ();
		}
	}
}

