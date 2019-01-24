using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaCup : MonoBehaviour {
    Rigidbody rg;
	// Use this for initialization
	void Start () {
        rg = transform.GetComponent<Rigidbody>();
        Yeet(new Vector2(10, 10));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Yeet(Vector2 dir) {
        rg.isKinematic = false;
        rg.velocity = new Vector3(dir.x, dir.y);
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().Hit();
        }
        Destroy(gameObject);
    }
}
