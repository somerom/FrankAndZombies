using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// controlls npc codys lines
/// </summary>
public class CodySaysController : MonoBehaviour {

    public int position = 0;
    private GameObject m1;
    private GameObject m2;
    private GameObject m3;
    private GameObject m4;
    private GameObject m5;
    private Button ok;

    /// <summary>
    /// finds five text objects and button ok. sets first text active and ohters unactive
    /// </summary>
    void Start()
    {
        m1 = GameObject.Find("M1");
        m2 = GameObject.Find("M2");
        m3 = GameObject.Find("M3");
        m4 = GameObject.Find("M4");
        m5 = GameObject.Find("M5");
        ok = GameObject.Find("Ok").GetComponent<Button>();
        m1.SetActive(true);
        m2.SetActive(false);
        m3.SetActive(false);
        m4.SetActive(false);
        m5.SetActive(false);
        ok.onClick.AddListener(() => ButtonPressed());
    }
		
    /// <summary>
    /// sets next text object active after click, after last text returns the game where dialogue started.
    /// </summary>
    public void ButtonPressed()
    {
        if (position == 0)
        {
            m2.SetActive(true);
            m1.SetActive(false);
        }
        if (position == 1)
        {
            m3.SetActive(true);
            m2.SetActive(false);
        }
        if (position == 2)
        {
            m3.SetActive(false);
            m4.SetActive(true);

        }
        if (position == 3)
        {
            m4.SetActive(false);
            m5.SetActive(true);
        }
        if (position == 4)
        {
            m5.SetActive(false);
            m1.SetActive(true);
            SceneManager.LoadScene("Toilets");
            GameObject player = GameObject.Find("Player");
            Vector3 v = new Vector3(-1.749f, 0.096f);
            player.transform.position = v;
        }
        position += 1;
    }
}
