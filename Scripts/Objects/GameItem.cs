using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour{

	public Sprite sprite;
	//public GameObject itemObject = new GameObject();
	private GameItem item;
	public GameObject BurgerItem;
	Inventory inv = new Inventory();


	public GameItem()
	{
	}

	void Start()
	{
		Instantiate(BurgerItem, new Vector3(1, 1), Quaternion.identity);


	}

    public void SetName(string name)
    {
        this.name = name;
    }
	
    public string GetName()
    {
        return this.name;
    }

	void OnTriggerEnter2D(Collider2D other)
	{



		if (other.gameObject.tag == "Player")
		{
			inv.AddItem (gameObject);
			Debug.Log ("picked up item");
			//Destroy (gameObject);
		}
			
	}
		
}
