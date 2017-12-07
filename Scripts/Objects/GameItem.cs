using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Instantiates collectibles in the game
/// </summary>
public class GameItem : MonoBehaviour{

	public GameObject BurgerItem;
	public GameObject StoreroomKey;
	public GameObject RoofKey;
	/// <summary>
	/// Checks the active scene and instantiates the items in the scene.
	/// </summary>
	void Start()
	{
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;

		if (sceneName == "Main") {
			Instantiate(BurgerItem, new Vector3(-0.54f, -0.05f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(0.57f, -0.05f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(1.17f, -0.05f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(1.8f, -0.05f), Quaternion.identity);

		}
		if (sceneName == "Kitchen") {
			Instantiate(BurgerItem, new Vector3(0f, 0.5f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(0f, 0.6f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(0.1f, 0.5f), Quaternion.identity);
			Instantiate(BurgerItem, new Vector3(0.1f, 0.6f), Quaternion.identity);

		}

		if (sceneName == "Storeroom") {
			Instantiate(RoofKey, new Vector3(-1.4f, 0.36f), Quaternion.identity);

		}
		if (sceneName == "Toilets") {
			Instantiate(StoreroomKey, new Vector3(1.8f, 1.05f), Quaternion.identity);

		}
			
	}

    public void SetName(string name)
    {
        this.name = name;
    }

}
