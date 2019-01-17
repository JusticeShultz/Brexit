using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum State { Idle, Guard, TeaHold, TeaYeet};
public class PlayerController : MonoBehaviour {
    State state;
    bool inAir;
    [SerializeField]
    int PlayerNumber;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 1) && transform.GetComponent<Rigidbody>().velocity.y <= 0) { //Grounded
            state = State.Idle;
            //if()
            inAir = false;
            transform.position = new Vector3(transform.position.x, hit.point.y + 0.999f, transform.position.z);
            transform.GetComponent<Rigidbody>().velocity = new Vector3(transform.GetComponent<Rigidbody>().velocity.x * 0.95f, transform.GetComponent<Rigidbody>().velocity.y, 0);
            if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) {
                state = State.Guard;
            }  else if (Input.GetAxis("Horizontal" + PlayerNumber) > 0) {
                transform.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber) * 5, 0, 0);
            } else if (Input.GetAxis("Horizontal" + PlayerNumber) < 0)
            {
                transform.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber) * 5, 0, 0);
            } else {
                transform.GetComponent<Rigidbody>().velocity = new Vector3(transform.GetComponent<Rigidbody>().velocity.x, 0, 0);
            }


        } else {
            inAir = true;
        }
    }
}
