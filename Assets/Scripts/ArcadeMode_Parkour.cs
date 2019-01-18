using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMode_Parkour_Door : MonoBehaviour
{
    public GameObject TargetDoor;
    public GameObject EventHolder;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == TargetDoor.name)
        {
            enabled = false;
        }
    }
}
