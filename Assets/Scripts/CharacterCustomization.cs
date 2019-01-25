using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    /*public GameObject Player1_Head;
    public GameObject Player2_Head;
    public GameObject Player1_Body;
    public GameObject Player2_Body;*/
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    public GameObject Arrow4;

    int P1Select = 1;
    int P2Select = 1;

    int HeadP1;
    int HeadP2;
    int BodyP1;
    int BodyP2;

    /*public Mesh Head_1; public Mesh Head_2; public Mesh Head_3; public Mesh Head_4; public Mesh Head_5; public Mesh Head_6; public Mesh Head_7; public Mesh Head_8; public Mesh Head_9;
    public Mesh Head_10; public Mesh Head_11; public Mesh Head_12; public Mesh Head_13; public Mesh Head_14; public Mesh Head_15; public Mesh Head_16;
    public Mesh Body_1; public Mesh Body_2; public Mesh Body_3; public Mesh Body_4; public Mesh Body_5;*/

    float LastDelta1 = 0;
    float LastDelta2 = 0;

    void Start ()
    {
        HeadP1 = PlayerPrefs.GetInt("Player1Head");
        HeadP2 = PlayerPrefs.GetInt("Player2Head");

        BodyP1 = PlayerPrefs.GetInt("Player1Body");
        BodyP2 = PlayerPrefs.GetInt("Player2Body");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Arrow1.SetActive(P1Select == 1);
        Arrow2.SetActive(P1Select == 2);
        Arrow3.SetActive(P2Select == 1);
        Arrow4.SetActive(P2Select == 2);

        PlayerPrefs.SetInt("Player1Head", HeadP1);
        PlayerPrefs.SetInt("Player2Head", HeadP2);
        PlayerPrefs.SetInt("Player1Body", BodyP1);
        PlayerPrefs.SetInt("Player2Body", BodyP2);

        if (HeadP1 == 0) HeadP1 = 1;
        if (HeadP2 == 0) HeadP2 = 1;
        if (BodyP1 == 0) BodyP1 = 1;
        if (BodyP2 == 0) BodyP2 = 1;

        //P1 up and down.
        if (Input.GetAxis("Vertical" + 1) > 0.1 && LastDelta1 < 0.01 && LastDelta1 > -0.01)
        {
            P1Select = Mathf.Clamp(++P1Select, 1, 2);
        }

        if (Input.GetAxis("Vertical" + 1) < -0.1 && LastDelta1 < 0.01 && LastDelta1 > -0.01)
        {
            P1Select = Mathf.Clamp(--P1Select, 1, 2);
        }

        //P2 up and down.
        if (Input.GetAxis("Vertical" + 2) > 0.1 && LastDelta2 < 0.01 && LastDelta2 > -0.01)
        {
            P2Select = Mathf.Clamp(++P2Select, 1, 2);
        }

        if (Input.GetAxis("Vertical" + 2) < -0.1 && LastDelta2 < 0.01 && LastDelta2 > -0.01)
        {
            P2Select = Mathf.Clamp(--P2Select, 1, 2);
        }

        //P1 left and right
        if (Input.GetAxis("Horizontal" + 1) > 0.1 && LastDelta1 < 0.01 && LastDelta1 > -0.01)
        {
            if (P1Select == 1)
                HeadP1 = Mathf.Clamp(++HeadP1, 1, 16);
            else if (P1Select == 2)
                BodyP1 = Mathf.Clamp(++BodyP1, 1, 5);
        }

        if (Input.GetAxis("Horizontal" + 1) < -0.1 && LastDelta1 < 0.01 && LastDelta1 > -0.01)
        {
            if (P1Select == 1)
                HeadP1 = Mathf.Clamp(--HeadP1, 1, 16);
            else if (P1Select == 2)
                BodyP1 = Mathf.Clamp(--BodyP1, 1, 5);
        }

        //P2 left and right
        if (Input.GetAxis("Horizontal" + 2) > 0.1 && LastDelta2 < 0.01 && LastDelta2 > -0.01)
        {
            if (P2Select == 1)
                HeadP2 = Mathf.Clamp(++HeadP2, 1, 16);
            else if (P2Select == 2)
                BodyP2 = Mathf.Clamp(++BodyP2, 1, 5);
        }

        if (Input.GetAxis("Horizontal" + 2) < -0.1 && LastDelta2 < 0.01 && LastDelta2 > -0.01)
        {
            if (P2Select == 1)
                HeadP2 = Mathf.Clamp(--HeadP2, 1, 16);
            else if (P2Select == 2)
                BodyP2 = Mathf.Clamp(--BodyP2, 1, 5);
        }

        //Last deltas
        LastDelta1 = Input.GetAxis("Vertical" + 1) + Input.GetAxis("Horizontal" + 1);
        LastDelta2 = Input.GetAxis("Vertical" + 2) + Input.GetAxis("Horizontal" + 2);
    }
}
