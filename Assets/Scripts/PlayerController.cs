using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum State { Idle, Guard, TeaHold, TeaYeet};
public class PlayerController : MonoBehaviour {
    private Rigidbody rg;//Transform rigidbody

    public float maxVelocity;//sqr of max velocity

    float currentVelocity;
    State state;
    bool inAir;
    [SerializeField]
    int PlayerNumber;
    public Animator animgraph;
    // Use this for initialization
    void Start () {
        rg = transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + new Vector3(0,1,0), -transform.up, out hit, 1) && rg.velocity.y <= 0) { //Grounded
            Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber), 0) * -6, 0) * Time.deltaTime * 10;
            rg.velocity += wishdir;
            Debug.DrawRay(transform.position, -transform.up, Color.yellow);
            state = State.Idle;
            inAir = false;
            transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
            rg.velocity = new Vector3(rg.velocity.x * 0.95f, rg.velocity.y, 0);
            if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) { //Jump //Not make the player go too fast.
                    rg.velocity = rg.velocity + new Vector3(0, 10, 0);
            } else if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5) {//Guard
                state = State.Guard;
                animgraph.SetInteger("State", 2);
                rg.velocity = new Vector3(0, 0, 0);
            }  else if (Input.GetAxis("Horizontal" + PlayerNumber) > 0) {
                animgraph.SetInteger("State", 1);
                transform.eulerAngles = new Vector3(0, 90, 0);
                rg.velocity = new Vector3(Mathf.Max(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
            } else if (Input.GetAxis("Horizontal" + PlayerNumber) < 0) {
                animgraph.SetInteger("State", 1);
                transform.eulerAngles = new Vector3(0, -90, 0);
                rg.velocity = new Vector3(Mathf.Min(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
            } else {
                animgraph.SetInteger("State", 0);
                rg.velocity = new Vector3(rg.velocity.x, 0, 0);
            }
        } else {
            inAir = true;
            animgraph.SetInteger("State", 4);
            Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber),0)*-10,0)*Time.deltaTime*6;
            rg.velocity += wishdir;
        }
        
    }
    public
    void Hit() {

    }
}
