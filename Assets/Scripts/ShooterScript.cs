using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour {

    public GameObject LaserBeam;

    public GameObject Projectile;

    public GameObject Particles;

    public float ProjectileSpeed = 100f;

    GameObject target;

    Vector3 shootDirection;

    // Use this for initialization
    void Start () {

        target = GameObject.FindGameObjectWithTag("Target");

	}
	
	// Update is called once per frame
	void Update () {

        shootDirection = target.transform.position - transform.position;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(shootDirection);
        }

        //LaserBeam.SetActive(Input.GetButton("Fire2"));

	}

    void Shoot(Vector3 dir)
    {

        GameObject bullet = Instantiate(Projectile);
        bullet.transform.position = transform.position + dir.normalized + new Vector3(0,1,0);
        bullet.GetComponent<Rigidbody>().velocity = dir.normalized * ProjectileSpeed;

    }

}
