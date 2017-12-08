using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// controlls the camera
/// </summary>
public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    private static Camera cameraInstance;

    /// <summary>
    /// makes the camera object singleton, so it can be in program as only one instance
    /// </summary>
    void Awake()
    {
        DontDestroyOnLoad(cameraInstance);

        if (cameraInstance == null)
        {
            cameraInstance = Camera.main;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    /// <summary>
    /// finds the player object and defines distance betweeen camera and player
    /// </summary>
    void Start () {
		player = GameObject.Find ("Player");
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    /// <summary>
    /// set the camera in the same palce as player
    /// </summary>
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
