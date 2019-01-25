using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FightMode_DoorLock : MonoBehaviour
{
    public GameObject BlueDoor;
    public GameObject RedDoor;
    public GameObject BlueDoorText;
    public GameObject RedDoorText;

    public int HitCountP1 = 3;
    public int HitCountP2 = 3;

    void Update ()
    {
        BlueDoorText.GetComponent<TextMeshPro>().text = HitCountP1.ToString();
        RedDoorText.GetComponent<TextMeshPro>().text = HitCountP2.ToString();

        HitCountP1 = Mathf.Clamp(HitCountP1, 0, 3);
        HitCountP2 = Mathf.Clamp(HitCountP2, 0, 3);

        if (HitCountP1 == 3)
            BlueDoor.GetComponent<Transform>().position = Vector3.Lerp(BlueDoor.GetComponent<Transform>().position, new Vector3(-19.12f, 1, 0), 0.01f);
        else if (HitCountP1 == 2)
            BlueDoor.GetComponent<Transform>().position = Vector3.Lerp(BlueDoor.GetComponent<Transform>().position, new Vector3(-19.12f, 2, 0), 0.01f);
        else if (HitCountP1 == 1)
            BlueDoor.GetComponent<Transform>().position = Vector3.Lerp(BlueDoor.GetComponent<Transform>().position, new Vector3(-19.12f, 2.5f, 0), 0.01f);
        else if (HitCountP1 == 0)
        {
            BlueDoorText.SetActive(false);
            BlueDoor.GetComponent<Transform>().position = Vector3.Lerp(BlueDoor.GetComponent<Transform>().position, new Vector3(-19.12f, 5, 0), 0.01f);
        }

        if (HitCountP2 == 3)
            RedDoor.GetComponent<Transform>().position = Vector3.Lerp(RedDoor.GetComponent<Transform>().position, new Vector3(15.3f, 1, 0), 0.01f);
        else if (HitCountP2 == 2)
            RedDoor.GetComponent<Transform>().position = Vector3.Lerp(RedDoor.GetComponent<Transform>().position, new Vector3(15.3f, 2, 0), 0.01f);
        else if (HitCountP2 == 1)
            RedDoor.GetComponent<Transform>().position = Vector3.Lerp(RedDoor.GetComponent<Transform>().position, new Vector3(15.3f, 2.5f, 0), 0.01f);
        else if (HitCountP2 == 0)
        {
            RedDoorText.SetActive(false);
            RedDoor.GetComponent<Transform>().position = Vector3.Lerp(RedDoor.GetComponent<Transform>().position, new Vector3(15.3f, 5, 0), 0.01f);
        }
    }
}