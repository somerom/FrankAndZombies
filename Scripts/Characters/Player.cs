using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public int intro = 0;
    private string position;
	Inventory inv;
	Text HPText;
	public AudioClip BurgerPickup;
	public AudioClip KeyPickup;
	public AudioClip HitSound;
	public AudioSource source;

    private static Player playerInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

    void Start () {
		inv = GameObject.Find ("Player").GetComponent<Inventory> ();
		source = GameObject.Find ("Player").GetComponent<AudioSource> ();
		BurgerPickup = Resources.Load<AudioClip> ("Sounds/BurgerPickup");
		KeyPickup = Resources.Load<AudioClip> ("Sounds/KeyPickup");
		HitSound = Resources.Load<AudioClip> ("Sounds/HitSound");

	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Pickup")
		{
			inv.AddItem (other.gameObject);
			Debug.Log ("picked up item");
			Destroy (other.gameObject);
			Debug.Log(other.gameObject.name);
		}

		if (other.gameObject.name == "BurgerItem(Clone)") {
			source.PlayOneShot (BurgerPickup);
		}

		if (other.gameObject.name == "StoreroomKey(Clone)" || other.gameObject.name == "RoofKey(Clone)") {
			source.PlayOneShot (KeyPickup);
		}

	}

	public void TakeDamage()
	{
		source.PlayOneShot (HitSound);
	}
    
}
