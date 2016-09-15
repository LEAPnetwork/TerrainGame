using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour {

    public GameObject TeleportPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {

        if(coll.tag == "Player")
        {
            coll.gameObject.transform.position = TeleportPoint.transform.position;
            coll.gameObject.transform.rotation = TeleportPoint.transform.rotation;
            TeleportPoint.GetComponent<ParticleSystem>().Play();
        }

    }

}
