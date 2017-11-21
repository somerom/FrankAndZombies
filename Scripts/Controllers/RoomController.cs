using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomController : MonoBehaviour {

	// Use this for initialization
	void Start () {
      /* Room main = new Room();
        main.SetName("Main");
        Room storeroom = new Room();
        storeroom.SetName("Storeroom");
        Room roof = new Room();
        roof.SetName("Roof");
        Room toilets = new Room();
        toilets.SetName("Toilets");
        Room kitchen = new Room();
        kitchen.SetName("Kitchen");
        main.SetNextRoom(kitchen);
        main.SetNextRoom(toilets);
        kitchen.SetNextRoom(storeroom);
        kitchen.SetNextRoom(main);
        storeroom.SetNextRoom(roof);
        storeroom.SetNextRoom(kitchen);
        roof.SRoom(stroreroom);
        toilets.SetNextRoom(main);
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Roof")
        {
            SceneManager.LoadScene("Roof");
        }
        if (Collision.gameObject.tag == "Toilets")
        {
            SceneManager.LoadScene("Toilets");
        }
        if (Collision.gameObject.tag == "Main")
        {
            SceneManager.LoadScene("Main");
        }
        if (Collision.gameObject.tag == "Storeroom")
        {
            SceneManager.LoadScene("Storeroom");
        }
        if (Collision.gameObject.tag == "Kitchen")
        {
            SceneManager.LoadScene("Kitchen");
        }

    }
}
