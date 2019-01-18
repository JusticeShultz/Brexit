using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArcadeMode_Parkour_Logic : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject TimerObj;

    public bool Player1 = false;
    public bool Player2 = false;
    int Timer = 300;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Player1 == true || Player2 == true)
        {
            Panel1.SetActive(Player1);
            Panel2.SetActive(Player2);

            if (Timer > 0)
            {
                --Timer;

                TimerObj.SetActive(true);

                if (Timer > 0)
                    TimerObj.GetComponent<Text>().text = "1";
                if (Timer > 60)
                    TimerObj.GetComponent<Text>().text = "2";
                if (Timer > 120)
                    TimerObj.GetComponent<Text>().text = "3";
                if (Timer > 180)
                    TimerObj.GetComponent<Text>().text = "4";
                if (Timer > 240)
                    TimerObj.GetComponent<Text>().text = "5";
            }
            else
            {
                if (Player1 == true && Player2 == false)
                {
                    //Player1 wins.
                }

                if (Player1 == false && Player2 == true)
                {
                    //Player2 wins.
                }

                if (Player1 == true && Player2 == true)
                {
                    //Draw.
                }
            }
        }
    }
}
