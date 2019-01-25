using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeOfObject { Player1Head, Player2Head, Player1Body, Player2Body }

public class SkinChanger : MonoBehaviour
{
    public TypeOfObject Skin;

    public Mesh Head_1; public Mesh Head_2; public Mesh Head_3; public Mesh Head_4; public Mesh Head_5; public Mesh Head_6; public Mesh Head_7; public Mesh Head_8; public Mesh Head_9;
    public Mesh Head_10; public Mesh Head_11; public Mesh Head_12; public Mesh Head_13; public Mesh Head_14; public Mesh Head_15; public Mesh Head_16;
    public Mesh Body_1; public Mesh Body_2; public Mesh Body_3; public Mesh Body_4; public Mesh Body_5;

    int HeadP1;
    int HeadP2;
    int BodyP1;
    int BodyP2;

    void Update ()
    {
        if (HeadP1 == 0) HeadP1 = 1;
        if (HeadP2 == 0) HeadP2 = 1;
        if (BodyP1 == 0) BodyP1 = 1;
        if (BodyP2 == 0) BodyP2 = 1;

        if (Skin == TypeOfObject.Player1Head)
        {
            HeadP1 = PlayerPrefs.GetInt("Player1Head");
            SetHeadP1();
        }
        else if (Skin == TypeOfObject.Player2Head)
        {
            HeadP2 = PlayerPrefs.GetInt("Player2Head");
            SetHeadP2();
        }
        else if (Skin == TypeOfObject.Player1Body)
        {
            BodyP1 = PlayerPrefs.GetInt("Player1Body");
            SetBodyP1();
        }
        else if (Skin == TypeOfObject.Player2Body)
        {
            BodyP2 = PlayerPrefs.GetInt("Player2Body");
            SetBodyP2();
        }
    }

    public void SetHeadP1()
    {
        if (HeadP1 == 1)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_1;
        if (HeadP1 == 2)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_2;
        if (HeadP1 == 3)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_3;
        if (HeadP1 == 4)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_4;
        if (HeadP1 == 5)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_5;
        if (HeadP1 == 6)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_6;
        if (HeadP1 == 7)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_7;
        if (HeadP1 == 8)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_8;
        if (HeadP1 == 9)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_9;
        if (HeadP1 == 10)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_10;
        if (HeadP1 == 11)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_11;
        if (HeadP1 == 12)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_12;
        if (HeadP1 == 13)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_13;
        if (HeadP1 == 14)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_14;
        if (HeadP1 == 15)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_15;
        if (HeadP1 == 16)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_16;
    }

    public void SetBodyP1()
    {
        if (BodyP1 == 1)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_1;
        if (BodyP1 == 2)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_2;
        if (BodyP1 == 3)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_3;
        if (BodyP1 == 4)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_4;
        if (BodyP1 == 5)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_5;
    }

    public void SetHeadP2()
    {
        if (HeadP2 == 1)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_1;
        if (HeadP2 == 2)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_2;
        if (HeadP2 == 3)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_3;
        if (HeadP2 == 4)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_4;
        if (HeadP2 == 5)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_5;
        if (HeadP2 == 6)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_6;
        if (HeadP2 == 7)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_7;
        if (HeadP2 == 8)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_8;
        if (HeadP2 == 9)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_9;
        if (HeadP2 == 10)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_10;
        if (HeadP2 == 11)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_11;
        if (HeadP2 == 12)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_12;
        if (HeadP2 == 13)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_13;
        if (HeadP2 == 14)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_14;
        if (HeadP2 == 15)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_15;
        if (HeadP2 == 16)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Head_16;
    }

    public void SetBodyP2()
    {
        if (BodyP2 == 1)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_1;
        if (BodyP2 == 2)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_2;
        if (BodyP2 == 3)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_3;
        if (BodyP2 == 4)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_4;
        if (BodyP2 == 5)
            GetComponent<SkinnedMeshRenderer>().sharedMesh = Body_5;
    }
}
