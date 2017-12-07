using UnityEngine;
using System.Collections;
/// <summary>
/// Back and forth1 handles the movement of the
/// faster zombies
/// This class is disabled if a zombie is hit with a burger
/// </summary>
public class BackAndForth1 : MonoBehaviour {
	/// <summary>
	/// Delta is the amount to move from the starting point
	/// Speed tells how fast the zombies run this loop
	/// </summary>
	private float delta = 0.4f; 
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
			speed = 3.0f;
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