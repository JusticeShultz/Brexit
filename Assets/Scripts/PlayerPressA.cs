using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Player { Player1, Player2 }

public class PlayerPressA : MonoBehaviour
{
    public Player PlayerSet;
    public string LevelToLoad;
    public bool IsBButton = false;
    public bool IsYButton = false;

    void Update ()
    {
        if (IsBButton)
        {
            if (PlayerSet == Player.Player1)
            {
                if (Input.GetButtonDown("BButtonP1"))
                {
                    changeScene(LevelToLoad);
                }
            }
            else if (PlayerSet == Player.Player2)
            {
                if (Input.GetButtonDown("BButtonP2"))
                {
                    changeScene(LevelToLoad);
                }
            }
        }
        else
        {
            if (IsYButton)
            {
                if (PlayerSet == Player.Player1)
                {
                    if (Input.GetButtonDown("YButtonP1"))
                    {
                        changeScene(LevelToLoad);
                    }
                }
                else if (PlayerSet == Player.Player2)
                {
                    if (Input.GetButtonDown("YButtonP2"))
                    {
                        changeScene(LevelToLoad);
                    }
                }
            }
            else
            {
                if (PlayerSet == Player.Player1)
                {
                    if (Input.GetButtonDown("AButtonP1"))
                    {
                        changeScene(LevelToLoad);
                    }
                }
                else if (PlayerSet == Player.Player2)
                {
                    if (Input.GetButtonDown("AButtonP2"))
                    {
                        changeScene(LevelToLoad);
                    }
                }
            }
        }
    }

    public void changeScene(string targetScene)
    {
        Debug.Log("Loading Scene");
        SceneManager.LoadScene(targetScene);
    }
}
