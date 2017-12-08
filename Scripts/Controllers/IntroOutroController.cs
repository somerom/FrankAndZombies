using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// controlls intro scene
/// </summary>
public class IntroOutroController : MonoBehaviour {

    private Button ok;
    private GameObject canvase;
    private GameObject player1;
    private Camera camera1;

    // Use this for initialization
    /// <summary>
    /// finds objects and calls method after button pressed
    /// </summary>
    void Start () {

        player1 = GameObject.Find("Player");
        camera1 = Camera.main;
        canvase = GameObject.Find("Canvas2");
        ok = GameObject.Find("Ok").GetComponent<Button>();
        ok.onClick.AddListener(() => ButtonPerssed());

    }
	
	// Update is called once per frame
	void Update () {
		
	}
     
    /// <summary>
    /// loads main scene after button click
    /// </summary>
    public void ButtonPerssed()
    {
        DontDestroyOnLoad(camera1);
        DontDestroyOnLoad(player1);
        DontDestroyOnLoad(canvase);
        SceneManager.LoadScene("Main");
    }



}
