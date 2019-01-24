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

        if(Direction)
            Yeet(new Vector2(10, 10));
        else Yeet(new Vector2(-10, 10));
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

        print("Spawn");

        if (!DoOnce)
        {
            Instantiate(shattered, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            DoOnce = true;
        }

        Destroy(gameObject);
    }
}
