using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourCamera : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    void Update ()
    {
		if(Player1.GetComponent<Transform>().position.y > Player2.GetComponent<Transform>().position.y)
        {
            GetComponent<Transform>().position = Vector3.Lerp(GetComponent<Transform>().position, new Vector3(0, Player1.GetComponent<Transform>().position.y + 10, -18.03f), 1.5f);
            GetComponent<Transform>().LookAt(Player1.GetComponent<Transform>());
        }
        else
        {
            GetComponent<Transform>().position = Vector3.Lerp(GetComponent<Transform>().position, new Vector3(0, Player2.GetComponent<Transform>().position.y + 10, -18.03f), 1.5f);
            GetComponent<Transform>().LookAt(Player2.GetComponent<Transform>());
        }
	}
}
