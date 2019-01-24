using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelection : MonoBehaviour
{
    public GameObject Race;
    public GameObject Fight;

    public GameObject RaceArrow;
    public GameObject FightArrow;

    public int Mode = 1;

    void Update()
    {
        if (GetComponent<ReadyupCheck>().CountdownTimer == 180)
        {
            if (Input.GetAxis("Horizontal" + 1) < -0.1)
            {
                Mode = 1;
            }

            if (Input.GetAxis("Horizontal" + 1) > 0.1)
            {
                Mode = 2;
            }

            RaceArrow.SetActive(Mode == 1);
            FightArrow.SetActive(Mode == 2);

            if (Mode == 1)
            {
                Race.GetComponent<RectTransform>().localScale = Vector3.Lerp(Race.GetComponent<RectTransform>().localScale, new Vector3(1, 1, 1), 0.03f);
                Fight.GetComponent<RectTransform>().localScale = Vector3.Lerp(Fight.GetComponent<RectTransform>().localScale, new Vector3(0.6f, 0.6f, 0.6f), 0.03f);
            }
            else if (Mode == 2)
            {
                Race.GetComponent<RectTransform>().localScale = Vector3.Lerp(Race.GetComponent<RectTransform>().localScale, new Vector3(0.6f, 0.6f, 0.6f), 0.03f);
                Fight.GetComponent<RectTransform>().localScale = Vector3.Lerp(Fight.GetComponent<RectTransform>().localScale, new Vector3(1, 1, 1), 0.03f);
            }
        }
    }
}
