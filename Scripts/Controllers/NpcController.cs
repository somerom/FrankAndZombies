using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NpcController : MonoBehaviour
{

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
    