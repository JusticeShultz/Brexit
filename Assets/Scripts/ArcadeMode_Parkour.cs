using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMode_Parkour : MonoBehaviour
{
    public GameObject TargetDoor;
    public GameObject EventHolder;
    public GameObject This;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == TargetDoor.name)
        {
            if (name == "Player1")
                EventHolder.GetComponent<ArcadeMode_Parkour_Logic>().Player1 = true;
            else if (name == "Player2")
                EventHolder.GetComponent<ArcadeMode_Parkour_Logic>().Player2 = true;

            //enabled = false;
            This.SetActive(false);
        }
    }
}
