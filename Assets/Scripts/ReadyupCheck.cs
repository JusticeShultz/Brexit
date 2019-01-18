using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadyupCheck : MonoBehaviour
{
    public GameObject Check1;
    public GameObject Check2;
    bool P1Ready = false;
    bool P2Ready = false;
    int CountdownTimer = 180;
	
	// Update is called once per frame
	void Update ()
    {
        Check1.GetComponent<Image>().enabled = P1Ready;
        Check2.GetComponent<Image>().enabled = P2Ready;

        if (Input.GetButtonDown("AButtonP1"))
        {
            P1Ready = !P1Ready;
        }

        if (Input.GetButtonDown("AButtonP2"))
        {
            P2Ready = !P2Ready;
        }

        if(P1Ready && P2Ready)
        {
            --CountdownTimer;
            GetComponent<Text>().enabled = true;

            if (CountdownTimer > 120)
            {
                GetComponent<Text>().text = "3";
            }
            else if (CountdownTimer > 60)
            {
                GetComponent<Text>().text = "2";
            }
            else if (CountdownTimer > 0)
            {
                GetComponent<Text>().text = "1";
            }
            else
            {
                GetComponent<Text>().text = "0";
                SceneManager.LoadScene("FightingScene");
            }
        }
        else
        {
            CountdownTimer = 180;
            GetComponent<Text>().enabled = false;
        }
    }
}
