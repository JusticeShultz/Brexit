using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        Panel1.SetActive(Player1);
        Panel2.SetActive(Player2);

        if (Player1 == true || Player2 == true)
        {
            TimerObj.SetActive(true);

            if (Timer > 0)
            {
                --Timer;

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
                    SceneManager.LoadScene("Player1_Win");
                }

                if (Player1 == false && Player2 == true)
                {
                    //Player2 wins.
                    SceneManager.LoadScene("Player2_Win");
                }

                if (Player1 == true && Player2 == true)
                {
                    //Draw.
                    SceneManager.LoadScene("PlayerDraw_Win");
                }
            }
        }
    }
}
