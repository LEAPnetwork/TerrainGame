using UnityEngine;
using System.Collections;

public class CameraRigMouseControl : MonoBehaviour {

    private GameObject player;

    public float MouseSensitivity = 1f;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {

        transform.position = player.transform.position;

        transform.Rotate(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0);
        

	}
}
