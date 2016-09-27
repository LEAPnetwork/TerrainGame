using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

    public GameObject particles1;
    public ParticleSystem particles2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        

	}

    void OnTriggerEnter(Collider col)
    {


        if(col.tag == "Player")
        {
            StartCoroutine(PickedUp());
        }

    }

    IEnumerator PickedUp()
    {

        GetComponent<Renderer>().enabled = false;

        Destroy(particles1);

        particles2.Play();

        yield return new WaitForSeconds(0.6f);

        Destroy(gameObject);


    }

}
