using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NpcController : MonoBehaviour
{


   // public Transform Cody;
   // public Transform Marilyn;
   
    
    private Text text;


    void Start()
    {
      



    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Marilyn")
        {
            SceneManager.LoadScene("MarilynSays");
        }


        if (collision.gameObject.name=="Cody")
        {
            SceneManager.LoadScene("CodySays");
        }
    }
}
    