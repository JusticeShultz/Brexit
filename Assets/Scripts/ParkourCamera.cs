using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourCamera : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject DummyCam;
    public bool IsDummy = false;

    void Update ()
    {
		if(Player1.GetComponent<Transform>().position.y > Player2.GetComponent<Transform>().position.y)
        {
            GetComponent<Transform>().position = Vector3.Lerp(GetComponent<Transform>().position, new Vector3(0, Player1.GetComponent<Transform>().position.y + 10, -18.03f), 0.05f);

            if (IsDummy)
                GetComponent<Transform>().LookAt(Player1.GetComponent<Transform>());
            else GetComponent<Transform>().rotation = Quaternion.Lerp(GetComponent<Transform>().rotation, DummyCam.GetComponent<Transform>().rotation, 0.01f);
        }
        else
        {
            GetComponent<Transform>().position = Vector3.Lerp(GetComponent<Transform>().position, new Vector3(0, Player2.GetComponent<Transform>().position.y + 10, -18.03f), 0.05f);

            if (IsDummy)
                GetComponent<Transform>().LookAt(Player2.GetComponent<Transform>());
            else GetComponent<Transform>().rotation = Quaternion.Lerp(GetComponent<Transform>().rotation, DummyCam.GetComponent<Transform>().rotation, 0.01f);
        }
	}
}
