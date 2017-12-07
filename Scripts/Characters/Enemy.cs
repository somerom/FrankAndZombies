using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Enemy class handles all the zombie related things
/// </summary>
public class Enemy : MonoBehaviour {
	/// <summary>
	/// Creating all the zombies, audio, animations
	/// and movement scripts
	/// </summary>
	
	private string type;
	public Transform Zombie1;
	public Transform Zombie2;
	public Transform Zombie3;
	public Transform Zombie3Kitchen;
	public Transform Zombie2Toilets;
	public Transform Zombie3Toilets;
	public Transform Zombie1Storeroom;
	public Transform Zombie1Big;
	public Transform Zombie1BigStill;
	public Transform Zombie2_2;
	public Transform Zombie1_2;
	Animator anim;
	private Transform target;
	public Component upAndDown;
	public Component backAndForth;
	public Component backAndForth1;
	public Component upAndDown1;

	public AudioClip ZombieEat;
	public AudioSource source;

	HitPoints player;
	/// <summary>
	/// Telling the game where every component is found
	/// and putting the zombies in their spesific rooms
	/// </summary>
	void Start () {
		source = GameObject.Find ("Enemy").GetComponent<AudioSource> ();
		ZombieEat = Resources.Load<AudioClip> ("Sounds/ZombieEat");
		GameObject.Find ("Enemy").GetComponent<AudioSource> ().clip = ZombieEat;
		player = GameObject.Find ("Player").GetComponent<HitPoints> ();
		upAndDown = GetComponent<UpAndDown> ();
		upAndDown1 = GetComponent<UpAndDown1> ();
		backAndForth = GetComponent<BackAndForth> ();
		backAndForth1 = GetComponent<BackAndForth1> ();
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;
		if (sceneName == "Main") {
			Instantiate (Zombie1, new Vector3 (1.3f, 1.9f), Quaternion.identity);
			Instantiate (Zombie2, new Vector3 (1.1f, 0.5f), Quaternion.identity);
			Instantiate (Zombie1BigStill, new Vector3 (1.97f, 0.74f), Quaternion.identity);

		}
		if (sceneName == "Toilets") {
			Instantiate (Zombie2Toilets, new Vector3 (-1.6f, 0.5f), Quaternion.identity);
			Instantiate (Zombie3Toilets, new Vector3 (-1.5f, 0.7f), Quaternion.identity);
			Instantiate (Zombie1, new Vector3 (1.5f, 0.92f), Quaternion.identity);
		}
		if (sceneName == "Roof") {
			Instantiate (Zombie1, new Vector3 (1.49f, 0.38f), Quaternion.identity);
			Instantiate (Zombie2, new Vector3 (-1.02f, 0.9f), Quaternion.identity);
			Instantiate (Zombie3, new Vector3 (-1.3f, 1.9f), Quaternion.identity);
			Instantiate (Zombie1Big, new Vector3 (-0.92f, 2.3f), Quaternion.identity);
			Instantiate (Zombie2_2, new Vector3 (0f, 0.26f), Quaternion.identity);
			Instantiate (Zombie1_2, new Vector3 (1.58f, 1.8f), Quaternion.identity);
			Instantiate (Zombie3Kitchen, new Vector3 (1.25f, 0.35f), Quaternion.identity);
		}
		if (sceneName == "Kitchen") {
			Instantiate (Zombie3Toilets, new Vector3 (-1.16f, -0.08f), Quaternion.identity);
			Instantiate (Zombie2Toilets, new Vector3 (-1.043f, 0.467f), Quaternion.identity);
		}
		if (sceneName == "Storeroom") {
			Instantiate (Zombie1Storeroom, new Vector3 (-1.19f, 0.1f), Quaternion.identity);
		}
		target = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	

	void Update () {
	}
	/// <summary>
	/// Raises the collision enter2 d event.
	/// If a zombie is hit with a burger the movement script
	/// is disabled.
	/// The movement script will be enabled again whenever the 
	/// player changes scenes
	/// </summary>
	/// <param name="Collision">Collision.</param>
	void OnCollisionEnter2D(Collision2D Collision)
	{
		if (Collision.gameObject.tag == "Bullet") {
			source.Play ();
			if (backAndForth != null){
				backAndForth.gameObject.GetComponent<BackAndForth> ().enabled = false;
		}
			if (backAndForth1 != null){
				backAndForth1.gameObject.GetComponent<BackAndForth1> ().enabled = false;
			}
			if (upAndDown != null) {
				upAndDown.gameObject.GetComponent<UpAndDown> ().enabled = false;
			}
			if (upAndDown1 != null) {
				upAndDown1.gameObject.GetComponent<UpAndDown1> ().enabled = false;
			}
			Destroy(Collision.gameObject);
	}
}
}
