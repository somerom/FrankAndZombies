using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : GameController{

	public const int numItemSlots = 3;
	public List<Image> itemImages = new List<Image>();
	//public List<GameItem> items = new List<GameItem>();
	public List<GameObject> items = new List<GameObject>();

	public void AddItem(GameObject ItemToAdd)
	{
		


		for (int i = 0; i < numItemSlots; i++) {
			
			items.Add (ItemToAdd);
			ListDebug ();
			

		}

		/*for(int i = 0; i < numItemSlots; i++){

			if (items [i] == null) {
				items [i] = ItemToAdd;
				itemImages [i].sprite = ItemToAdd.sprite;
				itemImages [i].enabled = true;
				return;
			}
		}*/
	
	}

	void ListDebug()
	{
		foreach (GameObject go in items) {
			Debug.Log (go.name);
			Debug.Log (items.Count);

		}
	}

	/*public void AddItem(GameItem ItemToAdd)
	{
		for(int i = 0; i < numItemSlots; i++){

			if (items [i] == null) {
				items [i] = ItemToAdd;
				itemImages [i].sprite = ItemToAdd.sprite;
				itemImages [i].enabled = true;
				return;
			}
		}

	}

	public void RemoveItem(GameItem ItemToRemove)
	{
		for(int i = 0; i < numItemSlots; i++){

			if (items [i] == ItemToRemove) {
				items [i] = null;
				itemImages [i].sprite = null;
				itemImages [i].enabled = false;
				return;
			}
		}

	}

    public bool IsOnInventoryItem(GameItem gi)
    {
        if (items.Contains(gi) == true)
        {
            return true;
        } else
        {
            return false;
        }
    }*/


}
