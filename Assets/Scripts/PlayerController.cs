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
        if (Physics.Raycast(transform.position + new Vector3(0,1,0), -transform.up, out hit, 1) && transform.GetComponent<Rigidbody>().velocity.y <= 0) { //Grounded
            Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber), 0) * -6, 0) * Time.deltaTime * 10;
            transform.GetComponent<Rigidbody>().velocity += wishdir;
            print(wishdir);
            Debug.DrawRay(transform.position, -transform.up, Color.yellow);
            state = State.Idle;
            //if()
            inAir = false;
            transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
            transform.GetComponent<Rigidbody>().velocity = new Vector3(transform.GetComponent<Rigidbody>().velocity.x * 0.95f, transform.GetComponent<Rigidbody>().velocity.y, 0);
            if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) { //jump
                transform.GetComponent<Rigidbody>().velocity = transform.GetComponent<Rigidbody>().velocity + new Vector3(0,10,0);
            } else if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5) {
                state = State.Guard;
                transform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                print("lmao");
            }  else if (Input.GetAxis("Horizontal" + PlayerNumber) > 0) {
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Max(Input.GetAxis("Horizontal" + PlayerNumber) * 5, transform.GetComponent<Rigidbody>().velocity.x), 0, 0);
            } else if (Input.GetAxis("Horizontal" + PlayerNumber) < 0) {
                transform.eulerAngles = new Vector3(0, -90, 0);
                transform.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Min(Input.GetAxis("Horizontal" + PlayerNumber) * 5, transform.GetComponent<Rigidbody>().velocity.x), 0, 0);
            } else {
                transform.GetComponent<Rigidbody>().velocity = new Vector3(transform.GetComponent<Rigidbody>().velocity.x, 0, 0);
            }


        } else {
            inAir = true;
            Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber),0)*-10,0)*Time.deltaTime*6;
            transform.GetComponent<Rigidbody>().velocity += wishdir;
        }
    }
}
