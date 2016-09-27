using UnityEngine;
using System.Collections;

public class LaserAim : MonoBehaviour {

    GameObject player;

    GameObject target;

    LineRenderer lr;

    Vector3[] v;

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

        target = GameObject.FindGameObjectWithTag("Target");

        lr = GetComponent<LineRenderer>();

        


    }
	
	// Update is called once per frame
	void Update () {

        v = new Vector3[] { player.transform.position + new Vector3(0,1,0), target.transform.position };

        lr.enabled = Input.GetButton("Fire2");

        if (lr.enabled)
        {
            lr.SetPositions(v);
        }

	}
}
