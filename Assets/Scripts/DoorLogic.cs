using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum DoorColor { Blue, Red }

public class DoorLogic : MonoBehaviour
{
    public DoorColor Door_Color;
    
    void OnCollisionEnter(Collision collision)
    {
        if (Door_Color == DoorColor.Blue)
        {
            if (collision.gameObject.name == "Player2")
            {
                //Player2 through the blue door.
                SceneManager.LoadScene("Player2_Win");
            }
        }
        else
        {
            if (collision.gameObject.name == "Player1")
            {
                //Player1 through the red door.
                SceneManager.LoadScene("Player1_Win");
            }
        }
    }
}
