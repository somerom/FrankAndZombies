using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DController : MonoBehaviour {

    private Button y;
    private Button n;
    private Text dText;
    Dialogues d = new Dialogues();
    // Use this for initialization
    void Start () {
        y = GameObject.Find("Yes").GetComponent<Button>();
        n = GameObject.Find("No").GetComponent<Button>();
        dText = GameObject.Find("Dialogue").GetComponent<Text>();
        y.onClick.AddListener(OnClickY);
        n.onClick.AddListener(OnClickN);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnClickY()
    {
        d.SetNewPosition("0");
        dText.text = d.GetNextLine().text;
    }
    private void OnClickN()
    {
        d.SetNewPosition("1");
        dText.text = d.GetNextLine().text;
    }
}
