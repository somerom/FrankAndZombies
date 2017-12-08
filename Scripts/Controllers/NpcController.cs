using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// cotrolls meeting npc
/// </summary>
public class NpcController : MonoBehaviour
{
    
   /// <summary>
   /// when player meets npc moves to the right dialoguescene
   /// </summary>
   /// <param name="collision"></param>

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
    