using UnityEngine;
using System.Collections;

public class CameraRigTiltControl : MonoBehaviour {

    public float MouseSensitivity = 1f;

    public bool InvertedTilt = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (InvertedTilt)
        {
            transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
        }
        else
        {
            transform.Rotate(-Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
        }
    }
}
