using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoomController : MonoBehaviour {
    
    private Camera camera;
    private GameObject canvase;
    private GameObject player1;
	private GameObject canvas;

	Inventory inv;
    private float timeToWait = 30.0f;

    // Use this for initialization
    void Start () {

        player1 = GameObject.Find("Player");
        camera = Camera.main;
        canvase = GameObject.Find("Canvas2");
		inv = GameObject.Find ("Player").GetComponent<Inventory> ();


    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Roof")
        {

			if (inv.RoofKeyCheck () == true) {
				DontDestroyOnLoad (camera);
				DontDestroyOnLoad (player1);
				DontDestroyOnLoad (canvase);
				inv.LockTextReset ();
				Vector3 v = new Vector3 (-0.95f, 3.35f);
				player1.transform.position = v;
				SceneManager.LoadScene ("Roof");
			} else {
				inv.LockText ();
			}

        }
        if (collision.gameObject.name == "Toilets")
        {
            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
            SceneManager.LoadScene("Toilets");
            Vector3 v = new Vector3(0.01f, 0.07f);
            player1.transform.position = v;
			//Instantiate(StoreroomKey, new Vector3(1.8f, 1.0f), Quaternion.identity);
        }
        if (collision.gameObject.name == "Maint")
        {
            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
            SceneManager.LoadScene("Main");
            Vector3 v = new Vector3(1.22f, 1.67f);
            player1.transform.position = v;
        }
        if (collision.gameObject.name == "Maink")
        {


            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
			inv.LockTextReset ();
            SceneManager.LoadScene("Main");
            Vector3 v = new Vector3(-1.03f, 0.34f);
            player1.transform.position = v;

        }
        if (collision.gameObject.name == "Storeroomr")
        {
			
            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
			Vector3 v = new Vector3(-0.85f, 0.70f);
            player1.transform.position = v;
            SceneManager.LoadScene("Storeroom");
            
        }
        if (collision.gameObject.name == "Storeroomk")
        {
			if (inv.StoreKeyCheck () == true) {
				DontDestroyOnLoad (camera);
				DontDestroyOnLoad (player1);
				DontDestroyOnLoad (canvase);
				SceneManager.LoadScene ("Storeroom");
				Vector3 v = new Vector3 (0.56f, -0.9f);
				player1.transform.position = v;
			} else {
				inv.LockText ();
			}

        }
        if (collision.gameObject.name == "Kitchens")
        {
            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
			inv.LockTextReset ();
            SceneManager.LoadScene("Kitchen");
            Vector3 v = new Vector3(-1.9f, 0.15f);
            player1.transform.position = v;
        }
        if (collision.gameObject.name == "Kitchenm")
        {
            DontDestroyOnLoad(camera);
            DontDestroyOnLoad(player1);
			DontDestroyOnLoad (canvase);
            SceneManager.LoadScene("Kitchen");
            Vector3 v = new Vector3(-1.03f, -0.3f);
            player1.transform.position = v;

        }
		if (collision.gameObject.name == "End") 

		{
            End();
		}
    }
    public void End()
    {
        SceneManager.LoadScene("Outro");        
    }

    
}

   
    

    
        
        

