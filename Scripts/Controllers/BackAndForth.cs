using UnityEngine;
using System.Collections;
/// <summary>
/// Back and forth handles the movement of the
/// faster zombies
/// This class is disabled if a zombie is hit with a burger
/// </summary>
public class BackAndForth : MonoBehaviour {

	private float delta = 0.4f;  // Amount to move left and right from the start point
	private float speed = 0f;    // The speed of the movement
	private Vector3 startPos;
	bool stop = false;

	void Start () {
		startPos = transform.position;

	}

	void Update () {
		if (stop == true) {
			
			speed = 0f;
		}else  {
			speed = 2.3f;
		}

		Vector3 v = startPos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;

	}


	public void Stop () {
		stop = true;
		speed = 0f;
	}
}