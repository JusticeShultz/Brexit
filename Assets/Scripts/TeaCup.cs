using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaCup : MonoBehaviour {
    Rigidbody rg;
    public GameObject shattered;
    public bool Direction = false;

    bool DoOnce = false;

	// Use this for initialization
	void Start () {
        rg = transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void yeet(Vector2 dir) {
        //print("YEET");
        transform.GetComponent<Rigidbody>().isKinematic = false;
        transform.GetComponent<Rigidbody>().velocity = new Vector3(dir.x, dir.y);
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().Hit(new Vector2(rg.velocity.x/4,12));
        }

        //print("Spawn");

        if (!DoOnce)
        {
            Instantiate(shattered, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            DoOnce = true;
        }

        Destroy(gameObject);
    }
}
