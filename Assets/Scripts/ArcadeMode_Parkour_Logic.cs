using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMode_Parkour_Logic : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject TimerObj;

    bool Player1 = false;
    bool Player2 = false;
    int Timer = 0;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Player1 == true || Player2 == true)
        {
            ++Timer;

            TimerObj.SetActive(true);

            /*if (Player1 == true && Player2 == false)
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
            }*/
        }
    }
}
