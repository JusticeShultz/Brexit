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
    void Update()
    {
        if (rg.velocity.x > 0.01) {
            transform.eulerAngles = new Vector3(0, 90, 0);
        } else if (rg.velocity.x < -0.01) {
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        RaycastHit hit;

        if (Physics.Raycast(transform.position + new Vector3(0,1,0), -transform.up * 1.01f, out hit, 1) && rg.velocity.y <= 0) //Grounded
        { 
            Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber), 0) * -6, 0) * Time.deltaTime * 10;
            rg.velocity += wishdir;
            Debug.DrawRay(transform.position, -transform.up, Color.yellow);
            state = State.Idle;
            inAir = false;
            transform.position = new Vector3(transform.position.x, hit.point.y-0.01f, transform.position.z);
            rg.velocity = new Vector3(rg.velocity.x * 0.95f, rg.velocity.y, 0);

<<<<<<< HEAD
            if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) //Jump 
            {
=======
            animgraph.SetInteger("State", 0);
            if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) //Jump
            { 
>>>>>>> ef395e27f9cf5d8778b52be165917a3dd65808ce
                rg.velocity = rg.velocity + new Vector3(0, 10, 0);
            } else if (inAir && rg.velocity.magnitude < rg.velocity.sqrMagnitude) {//falling 
                animgraph.SetBool("State",true);
            } else if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5) //Guard
            {
                state = State.Guard;
                animgraph.SetInteger("State", 2);
                rg.velocity = new Vector3(0, 0, 0);
            } else if (Input.GetAxis("Horizontal" + PlayerNumber) > 0)
            {
                animgraph.SetInteger("State", 1);
                if (!inAir)
                    rg.velocity = new Vector3(Mathf.Max(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
            } else if (Input.GetAxis("Horizontal" + PlayerNumber) < 0)
            {
                animgraph.SetInteger("State", 1);
                if (!inAir)
                    rg.velocity = new Vector3(Mathf.Min(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
            } else
            {
                rg.velocity = new Vector3(rg.velocity.x, 0, 0);
            }
        }
        else
        {
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
