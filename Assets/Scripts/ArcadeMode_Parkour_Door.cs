using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMode_Parkour : MonoBehaviour
{
    public GameObject TargetDoor;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == TargetDoor.name)
        {
            enabled = false;
        }
    }
}
