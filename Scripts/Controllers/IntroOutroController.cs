using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroOutroController : MonoBehaviour {

    private Button ok;
    private GameObject canvase;
    private GameObject player1;
    private Camera camera1;

    // Use this for initialization
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
     
    public void ButtonPerssed()
    {
        DontDestroyOnLoad(camera1);
        DontDestroyOnLoad(player1);
        DontDestroyOnLoad(canvase);
        SceneManager.LoadScene("Main");
    }



}
