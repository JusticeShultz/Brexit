using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontCollideWithPlayer : MonoBehaviour
{
    GameObject P1;
    GameObject P2;

    void Start ()
    {
        P1 = GameObject.Find("Player1");
        P2 = GameObject.Find("Player2");
        Physics.IgnoreCollision(GetComponent<Collider>(), P1.GetComponent<Collider>());
        Physics.IgnoreCollision(GetComponent<Collider>(), P2.GetComponent<Collider>());
    }
}
