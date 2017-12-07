﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MarilynSaysController : MonoBehaviour {

    public int position = 0;
    private List<GameObject> texts = new List<GameObject>();
    private GameObject m1;
    private GameObject m2;
    private GameObject m3;
    private GameObject m4;
    private GameObject m5;






    private Button ok;
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
        ok.onClick.AddListener(()=>ButtonPressed());
    }

    public void ButtonPressed()
    {
        if(position == 0)
        {
            m2.SetActive(true);
            m1.SetActive(false);
        }
        if (position == 1)
        {
            m3.SetActive(true);
            m2.SetActive(false);
        }
        if(position == 2)
        {
            m3.SetActive(false);
            m4.SetActive(true);

        }
        if(position == 3)
        {
            m4.SetActive(false);
            m5.SetActive(true);
        }
        if(position==4)
        {
            m5.SetActive(false);
            m1.SetActive(true);
            SceneManager.LoadScene("Kitchen");
            GameObject player = GameObject.Find("Player");
            Vector3 v = new Vector3(-0.5f, 0.3199f);
            player.transform.position = v;
        }
        position += 1;
    }
    
    
}
