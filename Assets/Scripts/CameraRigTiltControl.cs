using UnityEngine;
using System.Collections;

public class CameraRigTiltControl : MonoBehaviour {

    public float MouseSensitivity = 1f;

    public bool InvertedTilt = true;

    float scrollAmount;

    float zoomAmount = 1f;

    public float ZoomSensitivity = 1f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        scrollAmount = Input.GetAxis("Mouse ScrollWheel");

        zoomAmount = zoomAmount - (scrollAmount * ZoomSensitivity);

        transform.localScale = new Vector3(zoomAmount, zoomAmount, zoomAmount);

        if (InvertedTilt)
        {
            transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
        }
        else
        {
            transform.Rotate(-Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
        }

        /*
        if (Input.GetAxis("Mouse Y") > 0f)
        {
            if (transform.rotation.eulerAngles.x < 30f)
            {

                transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);

            }
        }
        else
        {
            if (transform.rotation.eulerAngles.x < 340f)
            {

                transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);

            }
        }



        /*
        if (Input.GetAxis("Mouse Y") > 0f && transform.rotation.eulerAngles.x < 40f)
        {

            if (InvertedTilt)
            {
                transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
            }
            else
            {
                transform.Rotate(-Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
            }
        }

        if (Input.GetAxis("Mouse Y") < 0f && transform.rotation.eulerAngles.x > -20f)
        {

            if (InvertedTilt)
            {
                transform.Rotate(Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
            }
            else
            {
                transform.Rotate(-Input.GetAxis("Mouse Y") * MouseSensitivity, 0, 0);
            }
        }
        */
    }
}
