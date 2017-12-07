using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    private static Camera cameraInstance;
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
    void Start () {
		player = GameObject.Find ("Player");
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
