using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Holds player's collected items and Inventory UI
/// </summary>
public class Inventory : MonoBehaviour{

	private static bool storeroomKey;
	private static bool roofKey;
	private static int burgerCount = 0;
	private static Text BurgerText;
	private static Text storeKeyText;
	private static Text roofKeyText;
	private static Text lockedText;
	private static Text burgNumber;

	/// <summary>
	/// Gets references to GameObjects.
	/// </summary>
	void Start()
	{
		storeroomKey = false;
		roofKey = false;
		BurgerText = GameObject.Find("BurgNumber").GetComponent<Text>();
		storeKeyText = GameObject.Find("StoreroomKeyText").GetComponent<Text>();
		roofKeyText = GameObject.Find("RoofKeyText").GetComponent<Text>();
		lockedText = GameObject.Find ("LockedText").GetComponent<Text> ();
		burgNumber = GameObject.Find ("BurgNumber").GetComponent<Text> ();

	}

	/// <summary>
	/// Resets items and UI, called when player presses "new game" button.
	/// </summary>
	public void Reset()
	{
		burgerCount = 0;
		storeroomKey = false;
		roofKey = false;
		storeKeyText.text = "";
		roofKeyText.text = "";
		burgNumber.text = "0";
	}
		
	/// <summary>
	/// Adds the item and updates UI.
	/// </summary>
	/// <param name="ItemToAdd">GameObject to be added to the inventory</param>
	public void AddItem(GameObject ItemToAdd)
	{

		if (ItemToAdd.name == "BurgerItem(Clone)") {
			burgerCount++;
			BurgerText.text = burgerCount.ToString ();
		}
		if (ItemToAdd.name == "StoreroomKey(Clone)") {
			storeroomKey = true;
			storeKeyText.text = "storeroom key";

		}
		if (ItemToAdd.name == "RoofKey(Clone)") {
			roofKey = true;
			roofKeyText.text = "roof key";
		}
	}
	/// <summary>
	/// Checks if the player has picked up the storeroom key.
	/// </summary>
	/// <returns><c>true</c>, if storeroom key was picked up, <c>false</c> otherwise.</returns>
	public bool StoreKeyCheck()
	{
		return storeroomKey;
	}

	/// <summary>
	/// Checks if the player has picked up the roof key.
	/// </summary>
	/// <returns><c>true</c>, if roof key was picked up, <c>false</c> otherwise.</returns>
	public bool RoofKeyCheck()
	{
		return roofKey;
	}

	/// <summary>
	/// Displays "locked" text on the screen.
	/// </summary>
	public void LockText()
	{
		lockedText.text = "locked";
	}

	/// <summary>
	/// Erases locktext.
	/// </summary>
	public void LockTextReset()
	{
		lockedText.text = "";
	}

	/// <summary>
	/// Reduces the burgercount and updates UI.
	/// </summary>
	public void ReduceBurger(){
		burgerCount--;
		BurgerText.text = burgerCount.ToString ();
	}

	/// <summary>
	/// Returns the amount of burgers player currently has.
	/// </summary>
	/// <returns>The amount of burgers.</returns>
	public int ItemCheck()
	{
		return burgerCount;
		
	}
}

