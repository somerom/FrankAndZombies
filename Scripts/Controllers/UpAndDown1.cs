using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

	private float delta = 0.27f;  // Amount to move left and right or up and down from the start point
	private float speed = 0f;
	private Vector3 startPos;
	bool stop = false;

	void Start () {
		startPos = transform.position;
	}

	void Update () {
		if (stop == true) {
			speed = 0f;
		}else  {
			speed = 3.2f;
		}

		Vector3 v = startPos;
		v.y += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}


	public void Stop () {
		stop = true;
		speed = 0f;
	}
}