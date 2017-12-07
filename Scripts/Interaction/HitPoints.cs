using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Holds the number of hitpoints the player has.
/// </summary>
public class HitPoints: MonoBehaviour {
	
	private static int hitPoints = 3;
	Text HPText;
	Player player;
	/// <summary>
	/// Gets references to GameObjects
	/// </summary>
	void Start()
	{
		player = GameObject.Find("Player").GetComponent<Player>();
		HPText = GameObject.Find("HitPointText").GetComponent<Text>();
	}
	/// <summary>
	/// If the player runs out of hitpoints, the game ends
	/// </summary>
	void Update () {
		if (hitPoints == 0) {
			GameOver ();
		}
	}
	/// <summary>
	/// Reduces hitpoints by 1 and updates the UI
	/// </summary>
	public void TakeDamage()
	{
		hitPoints--;
		string temp = "HP: " + hitPoints;
		HPText.text = temp;
	}
	/// <summary>
	/// Increases hitpoints to 3 to avoid conflicts with Update() and changes scene to Game Over scene
	/// </summary>
	void GameOver()
	{
		hitPoints = 3;
		SceneManager.LoadScene ("GameOver");
	}
	/// <summary>
	/// Collision detection between the player and enemies.
	/// </summary>
	/// <param name="Collision">Collision.</param>
	void OnCollisionEnter2D(Collision2D Collision)
	{
		if (Collision.gameObject.tag == "Enemy") {
			player.TakeDamage ();
			TakeDamage ();
		}
	}
}

