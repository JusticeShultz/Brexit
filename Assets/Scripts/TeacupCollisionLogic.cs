using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacupCollisionLogic : MonoBehaviour
{
    public Player player;
    GameObject P1;
    GameObject P2;

    void Start()
    {
        if (player == Player.Player1)
        {
            P1 = GameObject.Find("Player1");
            Physics.IgnoreCollision(GetComponent<Collider>(), P1.GetComponent<Collider>());
        }
        else
        {
            P2 = GameObject.Find("Player2");
            Physics.IgnoreCollision(GetComponent<Collider>(), P2.GetComponent<Collider>());
        }
    }
}
