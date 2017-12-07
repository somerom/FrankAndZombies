using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroController : MonoBehaviour {

    private Button ok;
	// Use this for initialization
	void Start () {
		ok = GameObject.Find("Ok").GetComponent<Button>();
        ok.onClick.AddListener(() => ButtonPressed());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ButtonPressed()
    {
        SceneManager.LoadScene("End");
    }
}
