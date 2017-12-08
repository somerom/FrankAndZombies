using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// controlls outro scene
/// </summary>
public class OutroController : MonoBehaviour {

    private Button ok;
	// Use this for initialization
    /// <summary>
    /// finds reference to button
    /// </summary>
	void Start () {
		ok = GameObject.Find("Ok").GetComponent<Button>();
        ok.onClick.AddListener(() => ButtonPressed());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// loads end scene after clicking the button
    /// </summary>
    public void ButtonPressed()
    {
        SceneManager.LoadScene("End");
    }
}
