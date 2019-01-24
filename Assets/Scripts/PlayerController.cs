using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rg;//Transform rigidbody
    public GameObject meBigBoyCup;
    public float maxVelocity;//sqr of max velocity
    public int StunTime = 35;

    float currentVelocity;
    bool inAir;
    [SerializeField]
    int PlayerNumber;
    public Animator animgraph;
    int CD = 35;
    bool Direction = false;
    int TeacupStun = 0;

    // Use this for initialization
    void Start () {
        rg = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TeacupStun > 0)
        {
            TeacupStun = Mathf.Clamp(TeacupStun, 0, StunTime);

            //Do the hit state here.
        }
        else
        {
            if (rg.velocity.x > 0.01)
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
                Direction = true;
            }
            else if (rg.velocity.x < -0.01)
            {
                transform.eulerAngles = new Vector3(0, -90, 0);
                Direction = false;
            }

            RaycastHit hit;

            if (Physics.Raycast(transform.position + new Vector3(0, 1, 0), -transform.up * 1.01f, out hit, 1) && rg.velocity.y <= 0) //Grounded
            {
                animgraph.SetInteger("State", 0);
                Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber), 0) * -6, 0) * Time.deltaTime * 10;
                rg.velocity += wishdir;
                Debug.DrawRay(transform.position, -transform.up, Color.yellow);
                inAir = false;
                //transform.position = new Vector3(transform.position.x, hit.point.y-0.01f, transform.position.z);
                rg.velocity = new Vector3(rg.velocity.x * 0.95f, rg.velocity.y, 0);

                if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5) //Jump
                {
                    rg.velocity = rg.velocity + new Vector3(0, 10, 0);
                }
                else if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5) //Guard
                {
                    --CD;

                    if (CD < 1)
                    {
                        if (Input.GetButtonDown("AButtonP1") && PlayerNumber == 1)
                        {
                            GameObject cup = Instantiate(meBigBoyCup, GetComponent<Transform>().position + new Vector3(0, 1, 0), GetComponent<Transform>().rotation);
                            CD = 35;
                            cup.GetComponent<TeacupCollisionLogic>().player = Player.Player1;

                            cup.GetComponent<TeaCup>().Direction = Direction;
                        }
                        else if (Input.GetButtonDown("AButtonP2") && PlayerNumber == 2)
                        {
                            GameObject cup = Instantiate(meBigBoyCup, GetComponent<Transform>().position + new Vector3(0, 1, 0), GetComponent<Transform>().rotation);
                            CD = 35;
                            cup.GetComponent<TeacupCollisionLogic>().player = Player.Player2;

                            cup.GetComponent<TeaCup>().Direction = Direction;
                        }
                    }

                    animgraph.SetInteger("State", 2);
                    rg.velocity = new Vector3(0, 0, 0);
                }
                else if (Input.GetAxis("Horizontal" + PlayerNumber) > 0)
                {
                    animgraph.SetInteger("State", 1);
                    if (!inAir)
                        rg.velocity = new Vector3(Mathf.Max(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
                }
                else if (Input.GetAxis("Horizontal" + PlayerNumber) < 0)
                {
                    animgraph.SetInteger("State", 1);
                    if (!inAir)
                        rg.velocity = new Vector3(Mathf.Min(Input.GetAxis("Horizontal" + PlayerNumber) * 5, rg.velocity.x), 0, 0);
                }
                else
                {
                    rg.velocity = new Vector3(rg.velocity.x, 0, 0);
                }
            }
            else
            {
                inAir = true;
                animgraph.SetInteger("State", 4);//(ANYTHING IN THE AIR I FUCKING GUESS)
                Vector3 wishdir = new Vector3(Input.GetAxis("Horizontal" + PlayerNumber), Mathf.Max(Input.GetAxis("Vertical" + PlayerNumber), 0) * -10, 0) * Time.deltaTime * 6;
                rg.velocity += wishdir;
                if (rg.velocity.magnitude < rg.velocity.sqrMagnitude)
                {//falling 
                    animgraph.SetBool("isFalling", true);
                }
            }
        }
        
    }
    public
    void Hit() {

    }
}
