using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Creates a listener for throwing a burger and throws a burger.
/// </summary>
public class BurgerThrow : MonoBehaviour {

	private float speed = 70;
	public Transform player;
	public Vector2 playerDir;
	public Rigidbody2D rb;
	public GameObject BurgerBullet;
	public GameObject burger;
	private Button bThrow;
	private float timeBetweenShots = 0.5f;
	private float timestamp;
	Inventory inv;
	/// <summary>
	/// Creates needed references for throwing a burger.
	/// </summary>
	void Start () {
		
		bThrow = GameObject.Find ("ButtonAction").GetComponent<Button> ();
		player = GameObject.Find ("Player").GetComponent<Transform> ();
		bThrow.onClick.AddListener (BurgThrow);
		BurgerBullet = Resources.Load ("Prefabs/BurgerBullet") as GameObject;
		inv = GameObject.Find ("Player").GetComponent<Inventory> ();

	}

	/// <summary>
	/// Checks if the player has burgers in the inventory and 
	/// instantiates a BurgerBullet prefab and adds force to it to the direction of the player.
	/// </summary>
	void BurgThrow ()
	{
		if (inv.ItemCheck () > 0) {

			if (Time.time >= timestamp) {
				burger = (GameObject)Instantiate (BurgerBullet, player.transform.position, Quaternion.identity);
				rb = burger.GetComponent<Rigidbody2D> ();
				rb.AddForce (GameController.playerDir * speed);
				Physics2D.IgnoreCollision (burger.GetComponent<BoxCollider2D> (), player.GetComponent<BoxCollider2D> ());
				timestamp = Time.time + timeBetweenShots;
				inv.ReduceBurger ();
			}

		}

	}
		
}
