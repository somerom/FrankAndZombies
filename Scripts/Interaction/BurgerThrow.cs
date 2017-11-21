using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerThrow : MonoBehaviour {

	public float speed;
	public Vector3 direction;

	private Button bThrow;


	void Start () {
		bThrow = GameObject.Find ("ButtonAction").GetComponent<Button> ();
		bThrow.onClick.AddListener(BurgThrow);

	}
	

	void Update () {
		
	}

	void BurgThrow ()
	{
		Debug.Log ("burger thrown");
	}
}
