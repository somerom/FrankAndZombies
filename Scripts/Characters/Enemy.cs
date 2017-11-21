using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	private string type;
	public Transform Zombie1;
	public Transform Zombie2;
	public Transform Zombie3;
	Animator anim;
	private Transform target;

	HitPoints player = new HitPoints();

	void Start () {

		Instantiate(Zombie1, new Vector3(0, 1), Quaternion.identity);
		Instantiate(Zombie2, new Vector3(-0.5f, 1), Quaternion.identity);
		Instantiate(Zombie3, new Vector3(-1, 1), Quaternion.identity);

		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	

	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D Collision)
	{
		if (Collision.gameObject.tag == "Player") {
			Debug.Log ("took damage");
			player.TakeDamage ();
		}
	}


}
