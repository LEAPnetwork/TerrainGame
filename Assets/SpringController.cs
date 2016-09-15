using UnityEngine;
using System.Collections;

public class SpringController : MonoBehaviour {

    [Range(0, 1000)] public float SpringStrength = 500f;

    private Animator anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {

        if(col.tag == "Player")
        {
            col.GetComponent<Rigidbody>().AddForce(new Vector3(0, SpringStrength, 0));
            anim.SetTrigger("Engage");
        }

    }



}
