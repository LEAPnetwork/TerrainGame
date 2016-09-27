using UnityEngine;
using System.Collections;

public class KillerSphere : MonoBehaviour {

    private Rigidbody rb;

    public GameObject[] Path;

    private Modes Mode = Modes.Patrolling;

    private enum Modes {Patrolling, Waiting, Charging}

    private int currentWaypoint = 0;

    private Vector3 playerPosition;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {



        switch (Mode)
        {
            case Modes.Patrolling:

                if (Path.Length == 0)
                {

                }
                else
                {

                    Vector3 dir = Path[currentWaypoint].transform.position - transform.position;

                    rb.AddForce(dir);



                    if (Vector3.Distance(Path[currentWaypoint].transform.position, transform.position) < 2f)
                    {
                        currentWaypoint++;
                        if (currentWaypoint >= Path.Length)
                        {
                            currentWaypoint = 0;
                        }
                    }
                }

                break;

            case Modes.Waiting:

                StartCoroutine(timer());

                break;

            case Modes.Charging:

                Vector3 playerDir = playerPosition - transform.position;

                rb.AddForce(playerDir * 5);

                break;

        }
	
	}

    void OnTriggerStay(Collider coll)
    {
        if(coll.tag == "Player")
        {

            Mode = Modes.Charging;

            playerPosition = coll.transform.position;

        }


    }

    void OnTriggerExit(Collider coll)
    {

        if (coll.tag == "Player")
        {

            Mode = Modes.Waiting;


        }

    }

    IEnumerator timer()
    {

        yield return new WaitForSeconds(3);

        Mode = Modes.Patrolling;

    }

}
